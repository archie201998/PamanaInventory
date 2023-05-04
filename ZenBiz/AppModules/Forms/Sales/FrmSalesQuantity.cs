using ZenBiz.AppModules.Forms.Components;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class FrmSalesQuantity : Form
    {
        private readonly int _itemId;
        private readonly FrmItemSearch _frmItemSearch;
        private readonly UcSalesForm _ucSalesForm;

        public FrmSalesQuantity(FrmItemSearch frmItemSearch, UcSalesForm ucSalesForm)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _itemId = frmItemSearch.ItemId;
            _frmItemSearch = frmItemSearch;
            _ucSalesForm = ucSalesForm;
        }

        private void SetPrice()
        {
            string priceType = "retail_price";
            if (radWholesalePrice.Checked) priceType = "wholesale_price";
            else if (radSpecialPrice.Checked) priceType = "special_price";

            nudPrice.Value = Factory.ItemsController().GetPrice(_itemId, priceType);
        }

        private void FrmSalesQuantity_Load(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void radRetailPrice_CheckedChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void radWholesalePrice_CheckedChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void radSpecialPrice_CheckedChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private bool SaveData()
        {
            var dict = Factory.ItemsController().FindById(_itemId);
            if (dict.Count == 0)
            {
                Helper.MessageBoxError("Item does not exist.");
                return false;
            }

            int storeId = Convert.ToInt32(_frmItemSearch.cmbStores.SelectedValue);
            string storeName = _frmItemSearch.cmbStores.Text;
            decimal stocksLeft = Factory.StoreStocksController().StocksLeft(storeId, _itemId);
            if (nudQuantity.Value > stocksLeft)
            {
                Helper.MessageBoxError("Please enter a quantity lesser than the remaining stocks.");
                return false;
            }

            decimal totalSale = nudPrice.Value * nudQuantity.Value;
            string[] row = new string[]
            {
                _frmItemSearch.ItemId.ToString(),
                storeId.ToString(),
                storeName,
                dict["name"],
                dict["unit_name"],
                nudPrice.Value.ToString("n2"),
                nudQuantity.Value.ToString("n2"),
                totalSale.ToString("n2"),
                dict["unit_cost"]
            };

            _ucSalesForm.dgItems.Rows.Add(row);
            _ucSalesForm.SumTotalSales();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Close();
            }
        }

    }
}
