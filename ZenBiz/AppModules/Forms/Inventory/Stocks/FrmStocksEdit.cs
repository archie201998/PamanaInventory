using System.Transactions;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocksEdit : Form
    {
        private readonly UcStocksForm uc;
        private readonly int _itemId;
        private readonly int _stockId;
        private readonly bool _isWarehouse;

        public FrmStocksEdit(int itemId, int stockId, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _itemId = itemId;
            _stockId = stockId;
            _isWarehouse = isWarehouse;
        }

        private void LoadData()
        {
            Dictionary<string, string> dict;
            int storeWarehouseId;
           
            dict = Factory.BranchStocksController().FindByStockId(_stockId);

            uc.txtUser.Text = dict["user"];
            uc.txtRemarks.Text = dict["remarks"];
            uc.cmbxStatus.Text = dict["status"];



            if (!string.IsNullOrEmpty(dict["repaired_date"]))
            {
                uc.dtpRepairedDate.Value = Convert.ToDateTime(dict["returned_date"]);
                uc.chkRepairedDate.Checked = true;
                uc.dtpRepairedDate.Enabled = true;
            }



            if (!string.IsNullOrWhiteSpace(dict["stock_date"]))
            {
                uc.dtpStockDate.Value = Convert.ToDateTime(dict["stock_date"]);
                uc.chkStockDate.Checked = true;
                uc.dtpStockDate.Enabled = true;
            }

            if (!string.IsNullOrWhiteSpace(dict["suppliers_id"]))
            {
                uc.cmbSupplier.SelectedValue = Convert.ToInt32(dict["suppliers_id"]);
                uc.chkSupplier.Checked = true;
                uc.cmbSupplier.Enabled = true;
            }
        }

        private void FrmStocksEdit_Load(object sender, EventArgs e)
        {
            uc.dtpStockDate.Enabled = false;
            uc.dtpRepairedDate.Enabled = false;
            uc.cmbSupplier.Enabled = false;
            LoadData();
        }

        private void UpdateStoreStock(int stockId, int storeId)
        {

            BranchStocksModel storeStocksModel = new()
            {
                Stock = new StocksModel() { Id = stockId },
                Store = new BranchModel() { Id = storeId }
            };

            _ = Factory.BranchStocksController().Update(storeStocksModel);
        }

        private bool SaveData()
        {
            using TransactionScope scope = new();
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            DateTime? stockDate = uc.chkStockDate.Checked ? uc.dtpStockDate.Value : null;
            int? suppliersId = uc.chkSupplier.Checked ? (int)uc.cmbSupplier.SelectedValue : null;
            StocksModel stocksModel = new()
            {
                Id = _stockId,
                Item = new ItemsModel() { Id = _itemId },
                Supplier = new SupplierModel() { Id = suppliersId },
                StockDate = stockDate,
            };

            _ = Factory.StocksController().Update(stocksModel);

            int storeWarehouseId = (int)uc.cmbStoreWarehouse.SelectedValue;
            UpdateStoreStock(_stockId, storeWarehouseId);

            scope.Complete();
            scope.Dispose();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Stock has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
