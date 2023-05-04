using System.Data;

namespace ZenBiz.AppModules.Forms.Users
{
    public partial class UcUsers : UserControl
    {
        internal bool IsEdit = false;

        public UcUsers()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epFirstName.GetError(txtFirstName),
                epLastName.GetError(txtLastName),
                epUsername.GetError(txtUsername),
                epPassword.GetError(txtPassword),
                epConfirmPassword.GetError(txtConfirmPassword)
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void LoadRoles()
        {
            Dictionary<int, string> rolesDict = new();
            DataTable dtRoles = Factory.RolesController().Fetch();
            foreach (DataRow item in dtRoles.Rows)
            {
                if (item["name"].ToString() != "Store Manager")
                    rolesDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());
            }
            cmbRoles.DataSource = new BindingSource(rolesDict, null);
            cmbRoles.DisplayMember = "Value";
            cmbRoles.ValueMember = "Key";
        }

        private void UcUsers_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadRoles();
            }
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epFirstName, txtFirstName, "first name");
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epFirstName, txtFirstName);
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epLastName, txtLastName, "last name");
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epLastName, txtLastName);
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEdit) return;
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epUsername, txtUsername, "username");

            string username = txtUsername.Text.Trim();
            if (Factory.UsersController().UsernameExist(username))
            {
                epUsername.SetError(txtUsername, "Username already exist. Please enter another.");
                e.Cancel = true;
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epUsername, txtUsername);
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEdit) return;
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epPassword, txtPassword, "password");
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epPassword, txtPassword);
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                epConfirmPassword.SetError(txtConfirmPassword, "Password does not match.");
                e.Cancel = true;
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            epConfirmPassword.Clear();
        }
    }
}
