namespace ZenBiz.AppModules.Forms.Sales.SalesServices
{
    public partial class FrmSalesServicesAdd : Form
    {
        private readonly UcSalesForm _ucSalesForm;
        private readonly UcSalesServices _ucSalesServices;

        public FrmSalesServicesAdd(UcSalesForm ucSalesForm)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _ucSalesServices = ucSalesServices1;
            _ucSalesForm = ucSalesForm;
        }

        private bool SaveData()
        {
            int serviceId = Convert.ToInt32(_ucSalesServices.cmbServices.SelectedValue);
            int personnelId = Convert.ToInt32(_ucSalesServices.cmbPersonnel.SelectedValue);
            string service = _ucSalesServices.cmbServices.Text;
            string personnel = _ucSalesServices.cmbPersonnel.Text;
            decimal fee = _ucSalesServices.nudFee.Value;

            string[] row = new string[]
            {
                serviceId.ToString(),
                personnelId.ToString(),
                service,
                personnel,
                fee.ToString(),
            };

            _ucSalesForm.dgServices.Rows.Add(row);
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Close();
            }
        }
    }
}
