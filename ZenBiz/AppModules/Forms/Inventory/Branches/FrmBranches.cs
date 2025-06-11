using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Stores
{
    public partial class FrmBranches : Form
    {
        public FrmBranches()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgStores, true);
        }

        private void CountRecords()
        {
            LblRecordCount.Text = dgStores.Rows.Count.ToString();
        }

        private void FetchData()
        {
            dgStores.DataSource = Factory.BranchesController().Fetch();
            dgStores.Columns["id"].Visible = false;
            dgStores.Columns["name"].HeaderText = "Name";
            dgStores.Columns["address"].HeaderText = "Address";
            CountRecords();
        }

        private void frmStores_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmBranchesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void dgStores_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgStores, btnEdit, btnDelete);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgStores.SelectedRows.Count == 0) return;

            try
            {
                List<BranchModel> storeModelList = new();
                foreach (DataGridViewRow item in dgStores.SelectedRows)
                    storeModelList.Add(new BranchModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.BranchesController().Delete(storeModelList);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgStores.SelectedRows.Count == 0) return;
            using FrmBranchesEdit form = new(Convert.ToInt32(dgStores.SelectedCells[0].Value));
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();
        }
    }
}
