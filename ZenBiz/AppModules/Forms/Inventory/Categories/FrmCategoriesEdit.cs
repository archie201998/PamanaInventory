using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Categories
{
    public partial class FrmCategoriesEdit : Form
    {
        private readonly UcCategories uc;

        public FrmCategoriesEdit(int categoriesId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucCategories1;
            uc.categoriesId = categoriesId;
        }

        private void LoadData()
        {
            var dict = Factory.CategoriesController().FindById(uc.categoriesId);
            uc.txtName.Text = dict["name"];
        }

        private void FrmCategoriesEdit_Load(object sender, EventArgs e)
        {
            LoadData();
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
                Id = uc.categoriesId,
                Name = uc.txtName.Text.Trim()
            };

            return Factory.CategoriesController().Update(categoriesModel);
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
