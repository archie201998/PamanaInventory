using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Suppliers
{
    public partial class FrmSuppliersAdd : Form
    {
        private readonly UcSupplier uc;

        public FrmSuppliersAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucSupplier1;
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            SupplierModel supplierModel = new()
            {
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim()
            };

            return Factory.SuppliersController().Insert(supplierModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Supplier has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
