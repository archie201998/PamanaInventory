using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Payments
{
    public partial class FrmPaymentsEdit : Form
    {
        private readonly int _paymentId;
        private readonly UcPayments uc;

        public FrmPaymentsEdit(int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
            uc = ucPayments1;
            Helper.FormFixedToolWindowDefaults(this);
        }

        private void LoadData()
        {
            var dict = Factory.PaymentsController().FindById(_paymentId);
            uc.cmbPaymentType.SelectedValue = Convert.ToInt32(dict["payment_types_id"]);
            uc.txtReferenceCode.Text = dict["ref_code"];
            uc.nudAmountPaid.Value = Convert.ToDecimal(dict["amount"]);
            uc.dtpPaymentDate.Value = Convert.ToDateTime(dict["date_paid"]);
        }

        private void FrmPaymentsEdit_Load(object sender, EventArgs e)
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

            PaymentsModel paymentsModel = new()
            {
                Id = _paymentId,
                PaymentTypes = new() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                Amount = uc.nudAmountPaid.Value,
                DatePaid = uc.dtpPaymentDate.Value,
                RefCode = uc.txtReferenceCode.Text.Trim(),
                Users = new() { Id = Helper.UserId }
            };
            return Factory.PaymentsController().Update(paymentsModel);
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
