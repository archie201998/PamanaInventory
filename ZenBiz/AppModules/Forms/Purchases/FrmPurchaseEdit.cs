using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchaseEdit : Form
    {
        private int _purchaseId;
        public FrmPurchaseEdit(int purchaseId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _purchaseId = purchaseId;
        }

        private void FrmPurchaseEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
