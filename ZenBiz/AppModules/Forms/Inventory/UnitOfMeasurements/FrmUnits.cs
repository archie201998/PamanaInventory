using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    public partial class FrmUnits : Form
    {
        public FrmUnits()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgUnit, true);
        }

        private void CountRecords()
        {
            lblRecordCount.Text = dgUnit.Rows.Count.ToString();
        }

        private void FetchData()
        {
            dgUnit.DataSource = Factory.UnitsOfMeasurementsController().Fetch();
            dgUnit.Columns["id"].Visible = false;
            dgUnit.Columns["abbreviation"].HeaderText = "Abbreviation";
            dgUnit.Columns["name"].HeaderText = "Name";
            CountRecords();
        }

        private void dgUnit_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgUnit, btnEdit, btnDelete);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmUnitsAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using FrmUnitsEdit form = new(Convert.ToInt32(dgUnit.SelectedCells[0].Value));
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUnit.SelectedRows.Count == 0) return;

            try
            {
                List<UnitOfMeasurementsModel> unitModelList = new();
                foreach (DataGridViewRow item in dgUnit.SelectedRows)
                    unitModelList.Add(new UnitOfMeasurementsModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.UnitsOfMeasurementsController().Delete(unitModelList);
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

        private void FrmUnits_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
