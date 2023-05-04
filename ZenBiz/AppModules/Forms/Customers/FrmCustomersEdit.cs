using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Customers
{
    public partial class FrmCustomersEdit : Form
    {
        private readonly int _customerId;
        private readonly UcCustomersForm uc;

        public FrmCustomersEdit(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            uc = ucCustomersForm1;
        }

        private void LoadSelectedData()
        {
            var dict = Factory.CustomersController().FindById(_customerId);
            uc.txtName.Text = dict["name"];
            uc.txtAddress.Text = dict["address"];
            uc.txtContactInfo.Text = dict["contact_info"];
        }

        private void FrmCustomersEdit_Load(object sender, EventArgs e)
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

            CustomersModel customersModel = new()
            {
                Id = _customerId,
                Name = uc.txtName.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.CustomersController().Update(customersModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Customer has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
