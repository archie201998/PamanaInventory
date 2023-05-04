using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Warehouses
{
    public partial class FrmWarehousesEdit : Form
    {
        private readonly UcWarehouses uc;

        public FrmWarehousesEdit(int warehouseId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucWarehouses1;
            uc.warehouseId = warehouseId;
        }

        private void LoadData()
        {
            var dict = Factory.WarehousesController().FindById(uc.warehouseId);
            uc.txtName.Text = dict["name"];
            uc.txtAddress.Text = dict["address"];
        }

        private void FrmWarehousesEdit_Load(object sender, EventArgs e)
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

            WarehousesModel warehousesModel = new()
            {
                Id = uc.warehouseId,
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim()
            };

            return Factory.WarehousesController().Update(warehousesModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Warehouse has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
