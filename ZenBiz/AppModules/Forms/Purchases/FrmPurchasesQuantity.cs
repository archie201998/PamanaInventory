using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Components;
using ZenBiz.AppModules.Forms.Sales;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchasesQuantity : Form
    {
        private readonly int _itemId;
        private readonly FrmItemSearch _frmItemSearch;
        private readonly UcPurchaseForm _ucPurchaseForm;

        public FrmPurchasesQuantity(FrmItemSearch frmItemSearch, UcPurchaseForm ucPurchaseForm)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _itemId = frmItemSearch.ItemId;
            _frmItemSearch = frmItemSearch;
            _ucPurchaseForm = ucPurchaseForm;
        }


    }
}
