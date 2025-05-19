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
            uc.panel2.Enabled = false;
            uc.txtTransactionNo.Text = Factory.SalesController().GenerateTransactionNumber().ToString().PadLeft(7, '0');
        }

        private void InsertSalesItem(ISales salesController)
        {
            foreach (DataGridViewRow item in uc.dgItems.Rows)
            {
                // populate sales item model
                SalesItemModel salesItemModel = new()
                {
                    Sales = new SalesModel() { Id = salesController.LastInsertedId() },
                    Items = new ItemsModel() { Id = Convert.ToInt32(item.Cells["ItemId"].Value) },
                    Stores = new BranchModel() { Id = Convert.ToInt32(item.Cells["StoreId"].Value) },
                    UnitCost = Convert.ToDecimal(item.Cells["UnitCost"].Value),
                    Price = Convert.ToDecimal(item.Cells["Price"].Value),
                    Quantity = Convert.ToDecimal(item.Cells["Quantity"].Value)
                };
                // insert sales item
                _ = Factory.SalesItemController().Insert(salesItemModel);
            }
        }

        private void InsertSalesServices(ISales salesController)
        {
            foreach (DataGridViewRow item in uc.dgServices.Rows)
            {
                int salesId = salesController.LastInsertedId();
                int serviceId = Convert.ToInt32(item.Cells["ServiceId"].Value);
                int personnelId = Convert.ToInt32(item.Cells["PersonnelId"].Value);
                decimal fee = Convert.ToDecimal(item.Cells["Fee"].Value);
                int storeId = Convert.ToInt32(item.Cells["StoreId"].Value);

                SalesServicesModel salesServicesModel = new()
                {
                    Sales = new SalesModel() { Id = salesId },
                    Services = new ServicesModel() { Id = serviceId },
                    Personnel = new PersonnelModel() { Id = personnelId },
                    Stores = new BranchModel() { Id = storeId },
                    Fee = fee
                };

                _ = Factory.SalesServicesController().Insert(salesServicesModel);
            }
        }

        private bool SaveData()
        {
            if (uc.dgItems.Rows.Count == 0 && uc.dgServices.Rows.Count == 0)
            {
                Helper.MessageBoxError("Please add an item or services.");
                return false;
            }

            using TransactionScope scope = new();
            // populate sales model
            SalesModel sales = new()
            {
                Customers = new CustomersModel() { Id = uc.CustomerId },
                TransactioNo = uc.txtTransactionNo.Text.Trim(),
                TransactionDate = uc.dtpTransactionDate.Value,
                TransactionDueDate = uc.dtpDueDate.Enabled ? uc.dtpDueDate.Value : null,
                Users = new UsersModel() { Id = Helper.UserId },
            };

            ISales salesController = Factory.SalesController();

            // insert sale
            _ = salesController.Insert(sales);

            if (uc.dgItems.Rows.Count != 0)
                InsertSalesItem(salesController);

            if (uc.dgServices.Rows.Count != 0)
                InsertSalesServices(salesController);

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
