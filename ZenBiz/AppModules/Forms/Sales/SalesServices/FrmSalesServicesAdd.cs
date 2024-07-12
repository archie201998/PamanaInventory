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
            int storeId = Convert.ToInt32(_ucSalesServices.cmbStores.SelectedValue);
            string service = _ucSalesServices.cmbServices.Text;
            string personnel = _ucSalesServices.cmbPersonnel.Text;
            string storeName = _ucSalesServices.cmbStores.Text;
            decimal fee = _ucSalesServices.nudFee.Value;


            bool ServiceAlreadyAdded()
            {
                foreach (DataGridViewRow item in _ucSalesForm.dgServices.Rows)
                {
                    string serviceIdOnList = item.Cells["ServiceId"].Value.ToString();
                    if (serviceId.ToString() == serviceIdOnList)
                        return true;
                }

                return false;
            }

            if (ServiceAlreadyAdded())
                Helper.MessageBoxError("Service is already on the list. Please check.");
            else
            {
                string[] row = new string[]
                {
                    serviceId.ToString(),
                    personnelId.ToString(),
                    storeId.ToString(),
                    storeName,
                    service,
                    personnel,
                    fee.ToString(),

                };

                _ucSalesForm.dgServices.Rows.Add(row);
                _ucSalesForm.SumTotalServiceFee();
                return true;
            }

            return false;
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
