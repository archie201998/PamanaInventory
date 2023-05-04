using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    public partial class FrmUnitsAdd : Form
    {
        private readonly UcUnits uc;

        public FrmUnitsAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucUnits1;
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            UnitOfMeasurementsModel unitsModel = new()
            {
                Abbreviation = uc.txtAbbreviation.Text.Trim(),
                Name = uc.txtName.Text.Trim()
            };

            return Factory.UnitsOfMeasurementsController().Insert(unitsModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Unit has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
