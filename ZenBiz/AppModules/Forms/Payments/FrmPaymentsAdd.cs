using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Payments
{
    public partial class FrmPaymentsAdd : Form
    {
        private readonly int _salesId;
        private readonly UcPayments uc;

        public FrmPaymentsAdd(int salesId)
        {
            InitializeComponent();
            _salesId = salesId;
            uc = ucPayments1;
            Helper.FormFixedToolWindowDefaults(this);
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            PaymentsModel paymentsModel = new()
            {
                Sales = new() { Id = _salesId },
                PaymentTypes = new() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                Amount = uc.nudAmountPaid.Value,
                DatePaid = uc.dtpPaymentDate.Value,
                RefCode = uc.txtReferenceCode.Text.Trim(),
                Users = new() { Id = Helper.UserId }
            };
            return Factory.PaymentsController().Insert(paymentsModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Payment has been saved.");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
