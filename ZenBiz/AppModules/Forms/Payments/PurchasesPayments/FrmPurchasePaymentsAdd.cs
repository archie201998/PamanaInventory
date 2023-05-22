using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Controllers;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Payments.PurchasesPayments
{
    public partial class FrmPurchasePaymentsAdd : Form
    {
        private readonly int _purchaseId;
        private readonly UcPayments uc;

        public FrmPurchasePaymentsAdd(int purchaseId)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _purchaseId = purchaseId;
            uc = ucPayments1;
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
                Purchase = new PurchasesModel() { Id = _purchaseId },
                PaymentTypes = new PaymentTypesModel() { Id = Convert.ToInt32(uc.cmbPaymentType.SelectedValue) },
                Amount = uc.nudAmountPaid.Value,
                DatePaid = uc.dtpPaymentDate.Value,
                RefCode = uc.txtReferenceCode.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.PurchasePaymentsController().Insert(purchasePaymentodel);
        }
    }
}
