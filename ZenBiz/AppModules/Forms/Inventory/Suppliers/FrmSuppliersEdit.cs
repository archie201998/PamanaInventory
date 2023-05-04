using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Suppliers
{
    public partial class FrmSuppliersEdit : Form
    {
        private readonly UcSupplier uc;

        public FrmSuppliersEdit(int suppliersId)
        {
            InitializeComponent();
            uc = ucSupplier1;
            uc.SuppliersId = suppliersId;
        }

        private void LoadSelectedSupplier()
        {
            var dict = Factory.SuppliersController().FindById(uc.SuppliersId);
            uc.txtName.Text = dict["name"];
            uc.txtAddress.Text = dict["address"];
            uc.txtContactInfo.Text = dict["contact_info"];
        }

        private void FrmSuppliersEdit_Load(object sender, EventArgs e)
        {
            LoadSelectedSupplier();
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
                Id = uc.SuppliersId,
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim()
            };

            return Factory.SuppliersController().Update(supplierModel);
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
