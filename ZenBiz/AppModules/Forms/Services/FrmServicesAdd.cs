using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Services
{
    public partial class FrmServicesAdd : Form
    {
        private readonly UcServices uc;

        public FrmServicesAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucServices1;
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
                Name = uc.txtName.Text.Trim(),
                Fee = Convert.ToDecimal(uc.nudFee.Value),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.ServicesController().Insert(servicesModel);
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
