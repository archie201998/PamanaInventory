using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Sales;
using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchases : Form
    {
        public FrmPurchases()
        {
            InitializeComponent();
            Helper.FormDialogDefaults(this, true, true);
            Helper.DatagridDefaultStyle(dgPurchases, true);
            Helper.DatagridDefaultStyle(dgPurchasesItems);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPurchasesAdd form = new();

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPurchases();
            }

            form.Dispose();
        }

        private void LoadPurchases()
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgPurchases.SelectedRows.Count == 0) return;
            //int purchaseId = Convert.ToInt32(dgPurchases.SelectedCells[0].Value);
            int purchaseId = 0;
            FrmPurchasesEdit form = new(purchaseId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPurchases();
            }

            form.Dispose();
        }
    }
}
