using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Stores
{
    public partial class FrmStoresAdd : Form
    {
        private readonly UcStore uc;
        public FrmStoresAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStore1;
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            StoresModel storesModel = new()
            {
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim()
            };

            return Factory.StoresController().Insert(storesModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Store has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
