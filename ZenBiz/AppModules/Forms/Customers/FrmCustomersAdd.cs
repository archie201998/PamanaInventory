using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Customers
{
    public partial class FrmCustomersAdd : Form
    {
        private readonly UcCustomersForm uc;

        public FrmCustomersAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucCustomersForm1;
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
                Name = uc.txtName.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.CustomersController().Insert(customersModel);
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
