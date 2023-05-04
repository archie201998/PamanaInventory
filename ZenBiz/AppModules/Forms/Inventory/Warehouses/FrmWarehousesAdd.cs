using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Inventory.Warehouses
{
    public partial class FrmWarehousesAdd : Form
    {
        private readonly UcWarehouses uc;

        public FrmWarehousesAdd()
        {
            InitializeComponent();
            uc = ucWarehouses1;
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
                Name = uc.txtName.Text.Trim(),
                Address = uc.txtAddress.Text.Trim()
            };

            return Factory.WarehousesController().Insert(warehousesModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Ware has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
