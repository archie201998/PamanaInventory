using ZenBiz.AppModules;

namespace ZenBiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.FormDialogDefaults(this, true, true);
            lblVersion.Text = $"Version {Application.ProductVersion}";
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                int? userId = Factory.UsersController().Authenticate(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (!userId.HasValue)
                {
                    Helper.MessageBoxError("Username or password is incorrect.");
                    return;
                }

                var dict = Factory.UsersController().FindById(Convert.ToInt32(userId));
                Helper.UserId = Convert.ToSByte(userId);
                Helper.LoggedInUserFullName = $"{dict["first_name"]} {dict["last_name"]}";
                Helper.UserType = dict["role_name"];
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                new MainForm(this).Show();
                Hide();
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
