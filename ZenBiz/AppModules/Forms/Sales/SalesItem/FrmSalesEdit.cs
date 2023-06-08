using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class FrmSalesEdit : Form
    {
        private readonly int _salesId;
        private readonly UcSalesForm uc;

        public FrmSalesEdit(int salesId)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _salesId = salesId;
            uc = ucSalesForm1;
        }

        private void LoadData()
        {
            var dict = Factory.SalesController().FindById(_salesId);
            uc.txtTransactionNo.Text = dict["trans_no"];
            uc.dtpTransactionDate.Value = Convert.ToDateTime(dict["trans_date"]);
            uc.CustomerId = string.IsNullOrWhiteSpace(dict["customers_id"]) ? 0 : Convert.ToInt32(dict["customers_id"]);
            if (uc.CustomerId != 0)
            {
                uc.txtCustomerName.Text = dict["customer_name"];
                uc.txtCustomerAddress.Text = dict["customer_address"];
                uc.txtCustomerContactInfo.Text = dict["customer_contact_info"];
            }

            var dtSalesItem = Factory.SalesItemController().FetchBySalesId(_salesId);
            foreach (DataRow item in dtSalesItem.Rows)
            {
                string[] row = new string[]
                {
                    item["items_id"].ToString(),
                    item["stores_id"].ToString(),
                    item["store_name"].ToString(),
                    item["item_name"].ToString(),
                    item["unit_name"].ToString(),
                    Convert.ToDecimal(item["sold_price"]).ToString("n2"),
                    Convert.ToDecimal(item["sold_quantity"]).ToString("n2"),
                    Convert.ToDecimal(item["total_sale"]).ToString("n2"),
                    item["sold_unit_cost"].ToString()
            };
                uc.dgItems.Rows.Add(row);
            }

            uc.SumTotalSales();
        }

        private void FrmSalesEdit_Load(object sender, EventArgs e)
        {
            LoadData();
            uc.chkPayment.Visible = false;
            uc.groupBoxPayments.Visible = false;
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
            SalesModel salesModel = new()
            {
                Id = _salesId,
                Customers = new CustomersModel() { Id = uc.CustomerId },
                TransactioNo = uc.txtTransactionNo.Text.Trim(),
                TransactionDate = uc.dtpTransactionDate.Value,
                Users = new UsersModel() { Id = Helper.UserId },
            };

            ISales salesController = Factory.SalesController();

            // insert sale
            _ = salesController.Update(salesModel);

            // delete all sales item
            _ = Factory.SalesItemController().DeletePerSalesId(_salesId);
            // inserting new sales items
            foreach (DataGridViewRow item in uc.dgItems.Rows)
            {
                // populate sales item model
                SalesItemModel salesItemModel = new()
                {
                    Sales = new SalesModel() { Id = _salesId },
                    Items = new ItemsModel() { Id = Convert.ToInt32(item.Cells["ItemId"].Value) },
                    Stores = new StoresModel() { Id = Convert.ToInt32(item.Cells["StoreId"].Value) },
                    UnitCost = Convert.ToDecimal(item.Cells["UnitCost"].Value),
                    Price = Convert.ToDecimal(item.Cells["Price"].Value),
                    Quantity = Convert.ToDecimal(item.Cells["Quantity"].Value)
                };

                _ = Factory.SalesItemController().Insert(salesItemModel);
            }

            scope.Complete();
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Transaction has been saved.");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
