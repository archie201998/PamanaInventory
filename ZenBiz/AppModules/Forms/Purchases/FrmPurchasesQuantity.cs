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
        private readonly UcPurchaseForm _ucPurchaseForm;
        FrmPurchasesItemsSearch _frmPurchasesItemsSearch;

        public FrmPurchasesQuantity(FrmPurchasesItemsSearch frmPurchasesItemsSearch, UcPurchaseForm ucPurchaseForm)
        {
            InitializeComponent();
            Helper.FormFixedToolWindowDefaults(this);
            _itemId = frmPurchasesItemsSearch.ItemId;
            _frmPurchasesItemsSearch = frmPurchasesItemsSearch;
            _ucPurchaseForm = ucPurchaseForm;
        }

        private void SetPrice()
        {
            nudPrice.Value = Factory.ItemsController().GetPrice(_itemId, "wholesale_price");
        }

        private void FrmPurchasesQuantity_Load(object sender, EventArgs e)
        {
            SetPrice();
        }

        private bool SaveData()
        {
            var dict = Factory.ItemsController().FindById(_itemId);
            if (dict.Count == 0)
            {
                Helper.MessageBoxError("Item does not exist.");
                return false;
            }

            decimal totalPurchase = nudPrice.Value * nudQuantity.Value;
            string[] row = new string[]
            {
                Convert.ToString(_frmPurchasesItemsSearch.ItemId),
                dict["name"],
                dict["unit_name"],
                nudPrice.Value.ToString("n2"),
                nudQuantity.Value.ToString("n2"),
                totalPurchase.ToString("n2"),
                dict["unit_cost"]
            };

            _ucPurchaseForm.dgItems.Rows.Add(row);
            _ucPurchaseForm.SumTotalPurchase();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Close();
            }
        }
    }
}
