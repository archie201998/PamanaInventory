using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Stores
{
    public partial class FrmBranchesEdit : Form
    {
        private readonly UcBranches uc;

        public FrmBranchesEdit(int storeId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStore1;
            uc.storeId = storeId;
        }

        private void LoadData()
        {
            var dict = Factory.StoresController().FindById(uc.storeId);
            uc.txtName.Text = dict["name"];
            uc.txtAddress.Text = dict["address"];
        }

        private void FrmStoresEdit_Load(object sender, EventArgs e)
        {
            LoadData();
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
                Id = uc.storeId,
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim()
            };

            return Factory.StoresController().Update(storesModel);
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
