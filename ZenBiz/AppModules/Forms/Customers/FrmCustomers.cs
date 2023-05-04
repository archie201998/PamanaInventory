using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Customers
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgCustomers, true);
        }

        private void LoadData()
        {
            dgCustomers.DataSource = Factory.CustomersController().Fetch();
            dgCustomers.Columns["id"].Visible = false;
            dgCustomers.Columns["name"].HeaderText = "Name";
            dgCustomers.Columns["contact_info"].HeaderText = "Contact Info";
            dgCustomers.Columns["address"].HeaderText = "Address";
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgCustomers.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmCustomersAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int customerId = (int)dgCustomers.SelectedCells[0].Value;
            using FrmCustomersEdit form = new(customerId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count == 0) return;

            try
            {
                List<CustomersModel> customersModelList = new();
                foreach (DataGridViewRow item in dgCustomers.SelectedRows)
                    customersModelList.Add(new CustomersModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.CustomersController().Delete(customersModelList);
                LoadData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void dgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgCustomers, btnEdit, btnDelete);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgCustomers.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtSearch.Text);
        }
    }
}
