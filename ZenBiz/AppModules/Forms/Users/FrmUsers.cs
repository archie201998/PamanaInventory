using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Users
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgUsers, true);
            Helper.FormDialogDefaults(this);
            Text = "Users";
        }

        private void LoadUsers()
        {
            dgUsers.DataSource = Factory.UsersController().Fetch();
            dgUsers.Columns["id"].Visible = false;
            dgUsers.Columns["roles_id"].Visible = false;
            dgUsers.Columns["first_name"].HeaderText = "First Name";
            dgUsers.Columns["last_name"].HeaderText = "Last Name";
            dgUsers.Columns["username"].HeaderText = "Username";
            dgUsers.Columns["role_name"].HeaderText = "Role";

            foreach (DataGridViewRow item in dgUsers.Rows)
                if (item.Cells["role_name"].Value.ToString() == "Store Manager")
                    dgUsers.Rows.Remove(item);

            dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmUsersAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadUsers();
            }
            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(dgUsers.SelectedCells[0].Value);
            using FrmUsersEdit form = new(userId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadUsers();
            }
            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0) return;

            try
            {
                List<UsersModel> usersModelList = new();
                foreach (DataGridViewRow item in dgUsers.SelectedRows)
                    usersModelList.Add(new UsersModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.UsersController().Delete(usersModelList);
                LoadUsers();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgUsers, btnEdit, btnDelete);
        }
    }
}
