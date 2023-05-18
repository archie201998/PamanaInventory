using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Payments.PurchasesPayments
{
    public partial class FrmPurchasePaymentsEdit : Form
    {
        private readonly int _paymentPurchaseId;
        private readonly UcPayments uc;
        public FrmPurchasePaymentsEdit(int aymentPurchaseId)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _paymentPurchaseId = aymentPurchaseId;
            uc = ucPayments1;
        }

        private void FrmPurchasePaymentsEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var dict = Factory.PurchasePaymentsController().FindById(_paymentPurchaseId);
            uc.cmbPaymentType.SelectedValue = Convert.ToInt32(dict["payment_types_id"]);
            uc.txtReferenceCode.Text = dict["ref_no"];
            uc.nudAmountPaid.Value = Convert.ToDecimal(dict["amount"]);
            uc.dtpPaymentDate.Value = Convert.ToDateTime(dict["date_paid"]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Payment has been saved.");
                DialogResult = DialogResult.OK;
            }
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            PurchasePaymentModel purchasePaymentodel = new()
            {
                Id = _paymentPurchaseId,
                PaymentTypes = new PaymentTypesModel() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                Amount = uc.nudAmountPaid.Value,
                DatePaid = uc.dtpPaymentDate.Value,
                RefCode = uc.txtReferenceCode.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.PurchasePaymentsController().Update(purchasePaymentodel);
        }
    }
}
