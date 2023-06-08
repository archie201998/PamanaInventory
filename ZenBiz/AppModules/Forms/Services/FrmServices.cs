using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Services
{
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgServices, true);
        }

        private void LoadData()
        {
            dgServices.DataSource = Factory.ServicesController().Fetch();
            dgServices.Columns["id"].Visible = false;
            dgServices.Columns["name"].HeaderText = "Name";
            dgServices.Columns["fee"].HeaderText = "Fee";
            dgServices.Columns["fee"].DefaultCellStyle.Format = "N2";
            dgServices.Columns["fee"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgServices.Columns["fee"].Width = 100;
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgServices.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgServices.SelectedRows.Count == 0) return;

            try
            {
                List<ServicesModel> servicesModelList = new();
                foreach (DataGridViewRow item in dgServices.SelectedRows)
                    servicesModelList.Add(new ServicesModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.ServicesController().Delete(servicesModelList);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmServicesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int serviceID = (int)dgServices.SelectedCells[0].Value;
            using FrmServicesEdit form = new(serviceID);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgServices.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtSearch.Text);
        }

        private void dgServices_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgServices, btnEdit, btnDelete);
        }
    }
}
