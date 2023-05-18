using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenBiz.AppModules.Forms.Payments.PurchasesPayments
{
    public partial class FrmPurchasePaymentsEdit : Form
    {
        private readonly int _purchaseId;
        private readonly UcPayments uc;
        public FrmPurchasePaymentsEdit(int purchaseId)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _purchaseId = purchaseId;
            uc = ucPayments1;
        }

        private void FrmPurchasePaymentsEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
