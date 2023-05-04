using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Categories
{
    public partial class FrmCategoriesAdd : Form
    {
        private readonly UcCategories uc;
        public FrmCategoriesAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucCategories1;
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            CategoriesModel categoriesModel = new()
            {
                Name = uc.txtName.Text.Trim()
            };

            return Factory.CategoriesController().Insert(categoriesModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Category has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
