using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Personnel
{
    public partial class FrmPersonnelAdd : Form
    {
        private readonly UcPersonnel uc;

        public FrmPersonnelAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucPersonnel1;
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
                Name = uc.txtName.Text.Trim(),
                ContactInfo = uc.txtContactInfo.Text.Trim(),
                Address = uc.txtAddress.Text.Trim(),
                Designation = uc.txtDesignation.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.PersonnelController().Insert(personnelModel);
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
