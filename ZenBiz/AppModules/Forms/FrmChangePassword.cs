using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules.Forms
{
    public partial class FrmChangePassword : Form
    {
        private readonly MainForm _mainForm;

        public FrmChangePassword(MainForm mainForm)
        {
            InitializeComponent();
            Helper.FormDialogDefaults(this);
            _mainForm = mainForm;
        }

        private bool ChangePassword()
        {
            IUsers usersController = Factory.UsersController();
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmNewPassword = txtConfirmNewPassword.Text.Trim();

            if (!usersController.CheckCurrentPassword(Helper.UserId, currentPassword))
            {
                Helper.MessageBoxError("Current password is incorrect.");
                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                Helper.MessageBoxError("Please fill up all fields.");
                return false;
            }

            if (newPassword != confirmNewPassword)
            {
                Helper.MessageBoxError("Password does not match.");
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();
                txtNewPassword.Focus();
                return false;
            }

            return usersController.ChangePassword(Helper.UserId, newPassword);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ChangePassword())
            {
                Helper.MessageBoxSuccess($"Password has been change successfully.{Environment.NewLine}{Environment.NewLine}This will invalidate your login session. Please login again.");
                Close();
                _mainForm.Close();
            }
        }
    }
}
