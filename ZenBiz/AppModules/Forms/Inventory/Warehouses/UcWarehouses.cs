using System.ComponentModel;

namespace ZenBiz.AppModules.Inventory.Warehouses
{
    public partial class UcWarehouses : UserControl
    {
        public int warehouseId = 0;

        public UcWarehouses()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epName.GetError(txtName),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
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
