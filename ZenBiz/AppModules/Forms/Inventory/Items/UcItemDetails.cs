using System.ComponentModel;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class UcItemDetails : UserControl
    {
        public UcItemDetails()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epName.GetError(txtName),
                epCode.GetError(txtCode),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = Factory.CategoriesController().Fetch();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
        }

        private void LoadUnit()
        {
            cmbUnit.DataSource = Factory.UnitsOfMeasurementsController().Fetch();
            cmbUnit.DisplayMember = "name";
            cmbUnit.ValueMember = "id";
        }

        private void UcItemDetails_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadCategories();
                LoadUnit();
            }
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epCode, txtCode, "code");
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epCode, txtCode);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epName, txtName, "name");
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epName, txtName);
        }
    }
}
