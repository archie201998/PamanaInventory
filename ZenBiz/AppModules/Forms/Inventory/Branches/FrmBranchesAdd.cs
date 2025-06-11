using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Stores
{
    public partial class FrmBranchesAdd : Form
    {
        private readonly UcBranches uc;
        public FrmBranchesAdd()
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

            BranchModel storesModel = new()
            {
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim()
            };

            return Factory.BranchesController().Insert(storesModel);
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
