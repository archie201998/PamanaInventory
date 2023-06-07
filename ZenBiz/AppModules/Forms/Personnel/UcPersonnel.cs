namespace ZenBiz.AppModules.Forms.Personnel
{
    public partial class UcPersonnel : UserControl
    {
        public UcPersonnel()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epName.GetError(txtName),
                epDesignation.GetError(txtDesignation),
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

        private void txtDesignation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epDesignation, txtDesignation, "designation");
        }

        private void txtDesignation_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epDesignation, txtDesignation);
        }
    }
}
