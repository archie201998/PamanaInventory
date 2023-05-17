using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules.Forms.Payments
{
    public partial class FrmPaymentPerPurchase : Form
    {

        private readonly int _purchaseId;

        public FrmPaymentPerPurchase(int purchaseId)
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgPayments, true);
            Helper.FormDialogDefaults(this, false, false);
            _purchaseId = purchaseId;
        }

        private void FrmPaymentPerPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}
