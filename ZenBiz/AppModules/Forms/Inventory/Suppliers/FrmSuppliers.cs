using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Suppliers
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgSuppliers, true);
        }

        private void LoadSuppliers()
        {
            dgSuppliers.DataSource = Factory.SuppliersController().Fetch();
            dgSuppliers.Columns["id"].Visible = false;
            dgSuppliers.Columns["name"].HeaderText = "Name";
            dgSuppliers.Columns["address"].HeaderText = "Address";
            dgSuppliers.Columns["contact_info"].HeaderText = "Contact Info";
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmSuppliersAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadSuppliers();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int supplierId = (int)dgSuppliers.SelectedCells[0].Value;
            using FrmSuppliersEdit form = new(supplierId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadSuppliers();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgSuppliers.SelectedRows.Count == 0) return;

            try
            {
                List<SupplierModel> supplierModelList = new();
                foreach (DataGridViewRow item in dgSuppliers.SelectedRows)
                    supplierModelList.Add(new SupplierModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.SuppliersController().Delete(supplierModelList);
                LoadSuppliers();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void dgSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgSuppliers, btnEdit, btnDelete);
        }
    }
}
