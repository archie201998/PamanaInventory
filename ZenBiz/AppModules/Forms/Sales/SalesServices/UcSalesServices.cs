namespace ZenBiz.AppModules.Forms.Sales.SalesServices
{
    public partial class UcSalesServices : UserControl
    {
        public UcSalesServices()
        {
            InitializeComponent();
        }
        private void LoadPersonnel()
        {
            cmbPersonnel.DataSource = Factory.PersonnelController().Fetch();
            cmbPersonnel.DisplayMember = "name";
            cmbPersonnel.ValueMember = "id";
        }

        private void LoadServices()
        {
            cmbServices.DataSource = Factory.ServicesController().Fetch();
            cmbServices.DisplayMember = "name";
            cmbServices.ValueMember = "id";
        }

        private void UcSalesServices_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadServices();
                LoadPersonnel();

                cmbServices.SelectedValueChanged -= cmbServices_SelectedValueChanged;
                GetServiceFee();
                cmbServices.SelectedValueChanged += cmbServices_SelectedValueChanged;

            }
        }

        private void GetServiceFee()
        {
            int serviceId = Convert.ToInt32(cmbServices.SelectedValue);
            Dictionary<string, string> servicesDict = Factory.ServicesController().FindById(serviceId);

            if (servicesDict.Count != 0)
                nudFee.Value = Convert.ToDecimal(servicesDict["fee"]);
        }

        private void cmbServices_SelectedValueChanged(object sender, EventArgs e)
        {
            GetServiceFee();
        }
    }
}
