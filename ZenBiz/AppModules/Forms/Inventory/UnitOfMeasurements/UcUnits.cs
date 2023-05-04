using System.ComponentModel;

namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    public partial class UcUnits : UserControl
    {
        public int unitId = 0;

        public UcUnits()
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

        private void txtAbbreviation_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epAbbreviation, txtAbbreviation, "abbreviation");
        }

        private void txtAbbreviation_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epAbbreviation, txtAbbreviation);
        }
    }
}
