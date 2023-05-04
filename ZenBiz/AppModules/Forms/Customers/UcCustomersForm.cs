namespace ZenBiz.AppModules.Forms.Customers
{
    public partial class UcCustomersForm : UserControl
    {
        public UcCustomersForm()
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

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epName, txtName, "name");
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epName, txtName);
        }
    }
}
