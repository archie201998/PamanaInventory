using ZenBiz.AppModules;
using ZenBiz.AppModules.Forms;
using ZenBiz.AppModules.Forms.Customers;
using ZenBiz.AppModules.Forms.Purchases;
using ZenBiz.AppModules.Forms.Reports;
using ZenBiz.AppModules.Forms.Sales;
using ZenBiz.AppModules.Forms.Users;
using ZenBiz.AppModules.Inventory;

namespace ZenBiz
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgPayingCustomers, true);
            Helper.DatagridDefaultStyle(dgSalesHistory, true);
            Helper.DatagridDefaultStyle(dgTopSellingProducts, true);
            _loginForm = loginForm;
        }

        private void TopSellingProducts()
        {
            dgTopSellingProducts.ColumnCount = 2;
            dgTopSellingProducts.Columns[0].HeaderText = "Item";
            dgTopSellingProducts.Columns[1].HeaderText = "Amount";

            dgTopSellingProducts.Rows.Add(new string[] { "Black Lion 265/ r19.5", "6,600.00" });
            dgTopSellingProducts.Rows.Add(new string[] { "Blacklion Voracio H/T BC86 235/75R15 105 S", "5,200.00" });
        }

        private void GrossSales()
        {
            lblGrossSales.Text = Factory.SalesItemController().GrossSales(dtpFrom.Value, dtpTo.Value).ToString("n2");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TopSellingProducts();
            GrossSales();
            lblCustomerCount.Text = Factory.CustomersController().Count().ToString();
            lblProductCount.Text = Factory.ItemsController().Count().ToString();
            btnLoggedInUser.Text = Helper.LoggedInUserFullName;
            Cursor.Current = Cursors.Default;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            _ = new frmInventory(_loginForm).ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            _ = new FrmCustomers().ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            _ = new FrmSales().ShowDialog();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            _ = new FrmPurchases().ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _ = new FrmUsers().ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.UserId = 0;
            Helper.LoggedInUserFullName = string.Empty;
            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            _ = new FrmReports().ShowDialog();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            GrossSales();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new FrmChangePassword(this).ShowDialog();
        }

    }
}
