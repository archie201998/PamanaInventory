using System.Transactions;
using ZenBiz.AppModules.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmItemsAdd : Form
    {
        private readonly UcItems uc;

        public FrmItemsAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucItems1;
        }

        private bool InsertItems()
        {
            ItemsModel itemsModel = new()
            {
                Categories = new CategoriesModel() { Id = Convert.ToInt32(uc.cmbCategory.SelectedValue) },
                UnitOfMeasurements = new UnitOfMeasurementsModel() { Id = Convert.ToInt32(uc.cmbUnit.SelectedValue) },
                Code = uc.txtCode.Text.Trim(),
                Name = uc.txtName.Text.Trim(),
                CreatedBy = new UsersModel() { Id = 1 }
            };

            return Factory.ItemsController().Insert(itemsModel);
        }

        private void InsertBranchStocks()
        {
            var stocksController = Factory.StocksController();
            var branchStocksController = Factory.BranchStocksController();

            foreach (DataGridViewRow item in uc.dgBranchStocks.Rows)
            {
                StocksModel stocksModel = new()
                {
                    Item = new ItemsModel() { Id = Factory.ItemsController().LastInsertedId() },
                    SerialNumber = item.Cells["serial_number"].Value?.ToString() ?? string.Empty,
                    Model = item.Cells["model"].Value?.ToString() ?? string.Empty,
                    OperatingSystem = item.Cells["operating_system"].Value?.ToString() ?? string.Empty,
                    RAM = item.Cells["ram"].Value?.ToString() ?? string.Empty,
                    ComputerName = item.Cells["computer_name"].Value?.ToString() ?? string.Empty,
                    SophosTamper = item.Cells["sophos_tamper"].Value?.ToString() ?? string.Empty,
                    DateAcquired = item.Cells["date_acquired"].Value != null ? Convert.ToDateTime(item.Cells["date_acquired"].Value) : DateTime.Now,
                    UnitCost = item.Cells["unit_cost"].Value != null ? Convert.ToDecimal(item.Cells["unit_cost"].Value) : 0,
                    Status = item.Cells["status"].Value?.ToString() ?? string.Empty,
                    Remarks = item.Cells["remarks"].Value?.ToString() ?? string.Empty,
                };

                stocksController.Insert(stocksModel);

                BranchStocksModel branchStocksModel = new()
                {
                    Stock = new StocksModel() { Id = stocksController.LastInsertedId() },
                    Branch = new BranchModel() { Id = Convert.ToInt32(item.Cells["branch_id"].Value) }
                };

                branchStocksController.Insert(branchStocksModel);
            }
        }



        private bool SaveData()
        {
            try
            {
                if (!uc.ValidateChildren())
                {
                    Helper.MessageBoxError(uc.GetFormErrors());
                    return false;
                }

                using TransactionScope scope = new();
                _ = InsertItems();
                InsertBranchStocks();

                scope.Complete();
                return true;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Item has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
