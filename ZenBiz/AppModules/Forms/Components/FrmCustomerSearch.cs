using ZenBiz.AppModules.Forms.Customers;

namespace ZenBiz.AppModules.Forms.Components
{
    public partial class FrmCustomerSearch : Form
    {
        internal int CustomerId;
        public FrmCustomerSearch()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgCustomers, true);
            Helper.FormDialogDefaults(this, false);
        }

        private void LoadCustomers(string query)
        {
            dgCustomers.DataSource = Factory.CustomersController().FetchBySearch(query);
            dgCustomers.Columns["id"].Visible = false;
            dgCustomers.Columns["name"].HeaderText = "Name";
            dgCustomers.Columns["contact_info"].HeaderText = "Contact Info";
            dgCustomers.Columns["address"].HeaderText = "Address";
        }

        private void FrmCustomerSearch_Load(object sender, EventArgs e)
        {

        }

        private void SelectCustomer()
        {
            CustomerId = (int)dgCustomers.SelectedCells[0].Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (query.Length < 3)
            {
                dgCustomers.DataSource = null;
                dgCustomers.Rows.Clear();
                return;
            };
            LoadCustomers(query);
        }

        private void dgCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectCustomer();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            _ = new FrmCustomersAdd().ShowDialog();
        }

    }
}
