using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Sales;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchasesAdd : Form
    {
        private readonly UcPurchaseForm uc;
        public FrmPurchasesAdd()
        {
            InitializeComponent();
            uc = ucPurchaseForm1;
            Helper.LoadFormIcon(this);
        }

        private void FrmPurchasesAdd_Load(object sender, EventArgs e)
        {

        }

        private bool SaveData()
        {
            if (uc.dgItems.Rows.Count == 0)
            {
                Helper.MessageBoxError("Please add an item.");
                return false;
            }

            using TransactionScope scope = new();
            // populate purchase model

            PurchasesModel purchases = new()
            {
                Supplier = new SupplierModel() { Id = uc.SupplierId },
                TransactionDate = uc.dtpDatePurchase.Value,
                Users = new UsersModel() { Id = Helper.UserId },
            };

            IPurchases purchaseController = Factory.PurchaseController();

            // insert purchase
            _ = purchaseController.Insert(purchases);

            foreach (DataGridViewRow item in uc.dgItems.Rows)
            {
                PurchaseItemsModel purchaseItemsModel = new()
                {
                    Purchases = new PurchasesModel() { Id = purchaseController.LastInsertedId() },
                    Items = new ItemsModel() { Id = Convert.ToInt32(item.Cells["ItemId"].Value) },
                    Amount = Convert.ToDecimal(item.Cells["Price"].Value),
                    Quantity = Convert.ToDecimal(item.Cells["Quantity"].Value)
                };

                _ = Factory.PurchaseItemController().Insert(purchaseItemsModel);
            }

            //if direct payment
            if (uc.chkPayment.Checked)
            {
                PurchasePaymentModel purchasePaymentodel = new()
                {
                    Purchase = new PurchasesModel() { Id = purchaseController.LastInsertedId() },
                    PaymentTypes = new PaymentTypesModel() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                    Amount = uc.nudAmountPaid.Value,
                    DatePaid = uc.dtpDatePaid.Value,
                    RefCode = uc.txtRefCode.Text.Trim(),
                    Users = new UsersModel() { Id = Helper.UserId }
                };

                _ = Factory.PurchasePaymentsController().Insert(purchasePaymentodel);
            }

            scope.Complete();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveData())
                {
                    Helper.MessageBoxInformation("Transaction has been saved.");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                Helper.MessageBoxError("Something went wrong. Failed to save the transaction.");
            }
        }
    }
}
