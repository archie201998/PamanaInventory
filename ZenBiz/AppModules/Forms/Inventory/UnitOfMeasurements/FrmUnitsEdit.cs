using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    public partial class FrmUnitsEdit : Form
    {
        private readonly UcUnits uc;

        public FrmUnitsEdit(int unitId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucUnits1;
            uc.unitId = unitId;
        }

        private void LoadData()
        {
            var dict = Factory.UnitsOfMeasurementsController().FindById(uc.unitId);
            uc.txtAbbreviation.Text = dict["abbreviation"];
            uc.txtName.Text = dict["name"];
        }

        private void FrmUnitsEdit_Load(object sender, EventArgs e)
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

            UnitOfMeasurementsModel unitsModel = new()
            {
                Id = uc.unitId,
                Abbreviation = uc.txtAbbreviation.Text.Trim(),
                Name = uc.txtName.Text.Trim()
            };

            return Factory.UnitsOfMeasurementsController().Update(unitsModel);
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
