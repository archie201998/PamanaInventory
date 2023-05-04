using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Users
{
    public partial class FrmUsersAdd : Form
    {
        private readonly UcUsers uc;

        public FrmUsersAdd()
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            uc = ucUsers1;
            Text = "Add User";
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            UsersModel usersModel = new()
            {
                FirstName = uc.txtFirstName.Text.Trim(),
                LastName = uc.txtLastName.Text.Trim(),
                Roles = new RolesModel() { Id = Convert.ToInt32(uc.cmbRoles.SelectedValue) },
                UserName = uc.txtUsername.Text.Trim(),
                Password = uc.txtPassword.Text.Trim(),
            };

            return Factory.UsersController().Insert(usersModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveData())
                {
                    Helper.MessageBoxSuccess("User has been saved.");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                Helper.MessageBoxError("Something went wrong. Faile to save the user.");
            }
        }
    }
}
