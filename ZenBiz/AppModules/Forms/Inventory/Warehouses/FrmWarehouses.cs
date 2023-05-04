using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Warehouses
{
    public partial class FrmWarehouses : Form
    {
        public FrmWarehouses()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgWarehouses, true);
        }

        private void CountRecords()
        {
            LblRecordsCount.Text = dgWarehouses.Rows.Count.ToString();
        }

        private void FetchData()
        {
            dgWarehouses.DataSource = Factory.WarehousesController().Fetch();
            dgWarehouses.Columns["id"].Visible = false;
            dgWarehouses.Columns["name"].HeaderText = "Name";
            dgWarehouses.Columns["address"].HeaderText = "Address";
            CountRecords();
        }

        private void dgWarehouses_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgWarehouses, btnEdit, btnDelete);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmWarehousesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using FrmWarehousesEdit form = new(Convert.ToInt32(dgWarehouses.SelectedCells[0].Value));
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgWarehouses.SelectedRows.Count == 0) return;

            try
            {
                List<WarehousesModel> warehousesModelList = new();
                foreach (DataGridViewRow item in dgWarehouses.SelectedRows)
                    warehousesModelList.Add(new WarehousesModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Warehouses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.WarehousesController().Delete(warehousesModelList);
                FetchData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void FrmWarehouses_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
