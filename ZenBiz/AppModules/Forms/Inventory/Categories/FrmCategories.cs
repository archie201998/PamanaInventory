using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Categories
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgCategories, true);
        }

        private void CountRecords()
        {
            LblRecordsCount.Text = dgCategories.Rows.Count.ToString();
        }

        private void FetchData()
        {
            dgCategories.DataSource = Factory.CategoriesController().Fetch();
            dgCategories.Columns["id"].Visible = false;
            dgCategories.Columns["name"].HeaderText = "Name";
            CountRecords();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmCategoriesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCategories.SelectedRows.Count == 0) return;
            using FrmCategoriesEdit form = new(Convert.ToInt32(dgCategories.SelectedCells[0].Value));
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                FetchData();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCategories.SelectedRows.Count == 0) return;

            try
            {
                List<CategoriesModel> categoriesModelList = new();
                foreach (DataGridViewRow item in dgCategories.SelectedRows)
                    categoriesModelList.Add(new CategoriesModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.CategoriesController().Delete(categoriesModelList);
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

        private void dgCategories_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgCategories, btnEdit, btnDelete);
        }
    }
}
