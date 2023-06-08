using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Services
{
    public partial class FrmServicesEdit : Form
    {
        private readonly int _serviceId;
        private readonly UcServices uc;

        public FrmServicesEdit(int serviceId)
        {
            InitializeComponent();
            _serviceId = serviceId;
            uc = ucServices1;
        }

        private void LoadSelectedData()
        {
            var dict = Factory.ServicesController().FindById(_serviceId);
            uc.txtName.Text = dict["name"];
            uc.nudFee.Value = Convert.ToDecimal(dict["fee"]);
        }

        private void FrmServicesEdit_Load(object sender, EventArgs e)
        {
            LoadSelectedData();
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            ServicesModel servicesModel = new()
            {
                Id = _serviceId,
                Name = uc.txtName.Text.Trim(),
                Fee = Convert.ToDecimal(uc.nudFee.Value),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.ServicesController().Update(servicesModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Service has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
