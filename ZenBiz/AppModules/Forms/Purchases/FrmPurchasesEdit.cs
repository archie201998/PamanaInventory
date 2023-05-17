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
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchasesEdit : Form
    {
        private int _purchaseId;
        private UcPurchaseForm uc;

        public FrmPurchasesEdit(int purchaseId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _purchaseId = purchaseId;
            uc = ucPurchaseForm1;
        }

        private void FrmPurchaseEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var dict = Factory.PurchaseController().FindById(_purchaseId);
            uc.dtpDatePurchase.Value = Convert.ToDateTime(dict["purchase_date"]);

            uc.SupplierId = string.IsNullOrWhiteSpace(dict["suppliers_id"]) ? 0 : Convert.ToInt32(dict["suppliers_id"]);
            if (uc.SupplierId != 0)
            {
                uc.txtSupplierName.Text = dict["name"];
                uc.txtSupplierAddress.Text = dict["address"];
                uc.txtSupplierContactInfo.Text = dict["contact_info"];
            }

            var dtPurchasedItem = Factory.PurchaseItemController().FetchByPurchaseId(_purchaseId);
            foreach (DataRow item in dtPurchasedItem.Rows)
            {
                string[] row = new string[]
                {
                    item["id"].ToString(),
                    item["purchases_id"].ToString(),
                    item["items_id"].ToString(),
                    item["amount"].ToString(),
                    item["quantity"].ToString(),
            };
                uc.dgItems.Rows.Add(row);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Transaction has been saved.");
                DialogResult = DialogResult.OK;
            }
        }

        private bool SaveData()
        {
            if (uc.dgItems.Rows.Count == 0)
            {
                Helper.MessageBoxError("Please add an item.");
                return false;
            }

            using TransactionScope scope = new();

            PurchasesModel purchasesModel = new()
            {
                Id = _purchaseId,
                Supplier = new SupplierModel() { Id = uc.SupplierId },
                TransactionDate = uc.dtpDatePurchase.Value,
                Users = new UsersModel() { Id = Helper.UserId },
            };

            IPurchases purchaseController = Factory.PurchaseController();

            _ = purchaseController.Update(purchasesModel);

            _ = Factory.PurchaseItemController().DeletePerPurchaseId(_purchaseId);

            foreach (DataGridViewRow item in uc.dgItems.Rows)
            {
                PurchaseItemsModel purchaseItemsModel = new()
                {
                    Purchases = new PurchasesModel() { Id = _purchaseId },
                    Items = new ItemsModel() { Id = Convert.ToInt32(item.Cells["ItemId"].Value) },
                    Amount = Convert.ToDecimal(item.Cells["Price"].Value),
                    Quantity = Convert.ToDecimal(item.Cells["Quantity"].Value)
                };

                _ = Factory.PurchaseItemController().Insert(purchaseItemsModel);
            }

            scope.Complete();
            return true;
        }
    }
}
