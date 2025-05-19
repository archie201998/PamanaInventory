namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class UcItemDetailsDisplay : UserControl
    {
        internal int ItemId;
        public UcItemDetailsDisplay()
        {
            InitializeComponent();
        }

        private void LoadItemDetails()
        {
            var dict = Factory.ItemsController().FindById(ItemId);
            txtCode.Text = dict["sku_code"];
            txtName.Text = dict["name"];
            txtCategory.Text = dict["category_name"];
            txtUnit.Text = dict["unit_name"];
            txtUnitCost.Text = Convert.ToDecimal(dict["unit_cost"]).ToString("N2");
            txtMinStockThreshold.Text = Convert.ToDecimal(dict["min_threshold_stock"]).ToString("N2");
        }

        private void UcItemDetailsDisplay_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadItemDetails();
            }
        }
    }
}
