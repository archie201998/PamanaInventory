using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class FrmSalesAdd : Form
    {
        private readonly UcSalesForm uc;

        public FrmSalesAdd()
        {
            InitializeComponent();
            uc = ucSalesForm1;
            Helper.LoadFormIcon(this);
        }

        private void FrmSalesAdd_Load(object sender, EventArgs e)
        {
            uc.groupBoxPayments.Enabled = false;
            uc.txtTransactionNo.Text = Factory.SalesController().GenerateTransactionNumber().ToString().PadLeft(7, '0');
        }

        private bool SaveData()
        {
            if (uc.dgItems.Rows.Count == 0)
            {
                Helper.MessageBoxError("Please add an item.");
                return false;
            }

            using TransactionScope scope = new();
            // populate sales model
            SalesModel sales = new()
            {
                Customers = new CustomersModel() { Id = uc.CustomerId },
                TransactioNo = uc.txtTransactionNo.Text.Trim(),
                TransactionDate = uc.dtpTransactionDate.Value,
                Users = new UsersModel() { Id = Helper.UserId },
            };

            ISales salesController = Factory.SalesController();

            // insert sale
            _ = salesController.Insert(sales);

            foreach (DataGridViewRow item in uc.dgItems.Rows)
            {
                // populate sales item model
                SalesItemModel salesItemModel = new()
                {
                    Sales = new SalesModel() { Id = salesController.LastInsertedId() },
                    Items = new ItemsModel() { Id = Convert.ToInt32(item.Cells["ItemId"].Value) },
                    Stores = new StoresModel() { Id = Convert.ToInt32(item.Cells["StoreId"].Value) },
                    UnitCost = Convert.ToDecimal(item.Cells["UnitCost"].Value),
                    Price = Convert.ToDecimal(item.Cells["Price"].Value),
                    Quantity = Convert.ToDecimal(item.Cells["Quantity"].Value)
                };
                // insert sales item
                _ = Factory.SalesItemController().Insert(salesItemModel);
            }

            if (uc.chkPayment.Checked)
            {
                PaymentsModel paymentsModel = new()
                {
                    Sales = new SalesModel() { Id = salesController.LastInsertedId() },
                    PaymentTypes = new PaymentTypesModel() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                    Amount = uc.nudAmountPaid.Value,
                    DatePaid = uc.dtpDatePaid.Value,
                    RefCode = uc.txtRefCode.Text.Trim(),
                    Users = new UsersModel() { Id = Helper.UserId }
                };

                _ = Factory.PaymentsController().Insert(paymentsModel);
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
