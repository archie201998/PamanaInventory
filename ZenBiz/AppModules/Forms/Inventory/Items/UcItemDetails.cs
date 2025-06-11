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
                epCategory.GetError(cmbCategory),
                epUOM.GetError(cmbUnit)
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void UcItemDetails_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Helper.LoadCategories(cmbCategory);
                Helper.LoadUnit(cmbUnit);
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
