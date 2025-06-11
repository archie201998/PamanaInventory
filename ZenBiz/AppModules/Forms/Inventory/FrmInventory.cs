using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Forms.Inventory.Suppliers;
using ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements;
using ZenBiz.AppModules.Inventory.Categories;
using ZenBiz.AppModules.Inventory.Stores;

namespace ZenBiz.AppModules.Inventory
{
    public partial class frmInventory : Form
    {
        private readonly LoginForm _loginForm;

        public frmInventory(LoginForm loginForm)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _loginForm = loginForm;
        }

        private void ShowMdiChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnItemsForm_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmItems(this));
        }

        private void btnStoresForm_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmBranches());
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmCategories());
        }

        private void btnUnitsForm_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmUnits());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmSuppliers());
        }
    }
}
