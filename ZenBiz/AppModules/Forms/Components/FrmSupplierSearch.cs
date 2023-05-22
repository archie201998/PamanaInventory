using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Inventory.Suppliers;
using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules.Forms.Components
{
    public partial class FrmSupplierSearch : Form
    {
        internal int SupplierId;

        public FrmSupplierSearch()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgSuppliers, true);
            Helper.FormDialogDefaults(this, false);

        }

        private void FrmSupplierSearch_Load(object sender, EventArgs e)
        {
            LoadSupplier(string.Empty);
        }

        private void LoadSupplier(string query)
        {
            dgSuppliers.DataSource = Factory.SuppliersController().FetchBySearch(query);
            dgSuppliers.Columns["id"].Visible = false;
            dgSuppliers.Columns["name"].HeaderText = "Name";
            dgSuppliers.Columns["address"].HeaderText = "Address";
            dgSuppliers.Columns["contact_info"].HeaderText = "Contact Info";
        }

        private void SelectSupplier()
        {
            SupplierId = (int)dgSuppliers.SelectedCells[0].Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            SelectSupplier();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            LoadSupplier(query);
        }

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            _ = new FrmSuppliersAdd().ShowDialog();
        }

        private void dgSuppliers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectSupplier();
        }
    }
}
