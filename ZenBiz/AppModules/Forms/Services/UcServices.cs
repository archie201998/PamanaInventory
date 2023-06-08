namespace ZenBiz.AppModules.Forms.Services
{
    public partial class UcServices : UserControl
    {
        public UcServices()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epName.GetError(txtName),
                epFee.GetError(nudFee),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epName, txtName, "name");
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epName, txtName);
        }

        private void nudFee_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorNumericUpDownEmpty(epFee, nudFee, "fee");
        }

        private void nudFee_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorNumericUpDown(epFee, nudFee);
        }
    }
}
