namespace ZenBiz.AppModules.Forms.Payments
{
    public partial class UcPayments : UserControl
    {
        public UcPayments()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epAmount.GetError(nudAmountPaid),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void LoadPaymentTypes()
        {
            cmbPaymentType.DataSource = Factory.PaymentTypesController().Fetch();
            cmbPaymentType.DisplayMember = "name";
            cmbPaymentType.ValueMember = "id";
        }

        private void UcPayments_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadPaymentTypes();
            }
        }

        private void nudAmountPaid_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorNumericUpDownEmpty(epAmount, nudAmountPaid, "amount");
        }

        private void nudAmountPaid_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorNumericUpDown(epAmount, nudAmountPaid);
        }
    }
}
