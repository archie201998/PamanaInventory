using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmItemsEdit : Form
    {
        private readonly int _id;
        private readonly UcItemDetails uc;

        public FrmItemsEdit(int itemId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _id = itemId;
            uc = ucItemDetails1;
        }

        private void LoadSelectedItemsData()
        {
            var data = Factory.ItemsController().FindById(_id);
            uc.txtCode.Text = data["sku_code"];
            uc.txtName.Text = data["name"];
            uc.nudRetailPrice.Value = Convert.ToDecimal(data["retail_price"]);
            uc.nudWholesalePrice.Value = Convert.ToDecimal(data["wholesale_price"]);
            uc.nudSpecialPrice.Value = Convert.ToDecimal(data["special_price"]);
            uc.nudMinStockThreshold.Value = Convert.ToDecimal(data["min_threshold_stock"]);
            uc.nudUnitCost.Value = Convert.ToDecimal(data["unit_cost"]);
            uc.cmbCategory.SelectedValue = Convert.ToInt32(data["categories_id"]);
            uc.cmbUnit.SelectedValue = Convert.ToInt32(data["unit_measurements_id"]);
        }

        private void FrmItemsEdit_Load(object sender, EventArgs e)
        {
            LoadSelectedItemsData();
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            ItemsModel itemsModel = new()
            {
                Id = _id,
                Categories = new CategoriesModel() { Id = Convert.ToInt32(uc.cmbCategory.SelectedValue) },
                UnitOfMeasurements = new UnitOfMeasurementsModel() { Id = Convert.ToInt32(uc.cmbUnit.SelectedValue) },
                Code = uc.txtCode.Text.Trim(),
                Name = uc.txtName.Text.Trim(),
                UnitCost = uc.nudUnitCost.Value,
                RetailPrice = uc.nudRetailPrice.Value,
                WholesalePrice = uc.nudWholesalePrice.Value,
                SpecialPrice = uc.nudSpecialPrice.Value,
                MinimumThresholdStocks = (float)uc.nudMinStockThreshold.Value,
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.ItemsController().Update(itemsModel);
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
