using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Users
{
    public partial class FrmUsersEdit : Form
    {
        private readonly UcUsers uc;
        private readonly int _userId;

        public FrmUsersEdit(int userId)
        {
            InitializeComponent();
            uc = ucUsers1;
            uc.IsEdit = true;
            Helper.FormFixedToolWindowDefaults(this);
            _userId = userId;
            Text = "Edit User";
        }

        private void LoadData()
        {
            var dict = Factory.UsersController().FindById(_userId);
            uc.txtFirstName.Text = dict["first_name"];
            uc.txtLastName.Text = dict["last_name"];
            uc.cmbRoles.Text = dict["roles_id"];
            uc.txtUsername.Text = dict["username"];
        }

        private void FrmUsersEdit_Load(object sender, EventArgs e)
        {
            LoadData();
            uc.txtUsername.Enabled = false;
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
                Id = _userId,
                FirstName = uc.txtFirstName.Text.Trim(),
                LastName = uc.txtLastName.Text.Trim(),
                Roles = new RolesModel() { Id = Convert.ToInt32(uc.cmbRoles.SelectedValue) },
                UserName = uc.txtUsername.Text.Trim(),
                Password = uc.txtPassword.Text.Trim(),
            };

            if (string.IsNullOrWhiteSpace(uc.txtPassword.Text))
                return Factory.UsersController().UpdateWithoutPassword(usersModel);

            return Factory.UsersController().Update(usersModel);
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
