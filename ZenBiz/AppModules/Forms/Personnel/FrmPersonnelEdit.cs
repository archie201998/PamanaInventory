using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Personnel
{
    public partial class FrmPersonnelEdit : Form
    {
        private readonly int _personnelId;
        private readonly UcPersonnel uc;

        public FrmPersonnelEdit(int personnelID)
        {
            InitializeComponent();
            _personnelId = personnelID;
            uc = ucPersonnel1;
        }

        private void LoadSelectedData()
        {
            var dict = Factory.PersonnelController().FindById(_personnelId);
            uc.txtName.Text = dict["name"];
            uc.txtAddress.Text = dict["address"];
            uc.txtContactInfo.Text = dict["contact_info"];
            uc.txtDesignation.Text = dict["designation"];
        }

        private void FrmPersonnelEdit_Load(object sender, EventArgs e)
        {
            LoadSelectedData();
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            PersonnelModel personnelModel = new()
            {
                Id = _personnelId,
                Name = uc.txtName.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                Designation = uc.txtDesignation.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.PersonnelController().Update(personnelModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Personnel has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
