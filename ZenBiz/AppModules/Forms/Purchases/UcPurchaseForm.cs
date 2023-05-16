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
using ZenBiz.AppModules.Forms.Inventory.Suppliers;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class UcPurchaseForm : UserControl
    {
        internal int SupplierId;

        public UcPurchaseForm()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgItems);
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            using FrmSupplierSearch form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SelectedSupplier(form.SupplierId);
            }

            form.Dispose();
        }

        private void SelectedSupplier(int supplierId)
        {
            SupplierId = supplierId;

            var dict = Factory.SuppliersController().FindById(SupplierId);
            txtSupplierName.Text = dict["name"];
            txtSupplierAddress.Text = dict["address"];
            txtSupplierContactInfo.Text = dict["contact_info"];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SupplierId = 0;
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierContactInfo.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _ = new FrmItemSearch(this, null).ShowDialog();
        }

        private void chkPayment_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPayments.Enabled = chkPayment.Checked;
            cmbPaymentType.SelectedIndex = 0;
            txtRefCode.Clear();
            nudAmountPaid.Value = 0;
        }

        private void UcPurchaseForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CreateColumns();
                LoadPaymentTypes();
            }
        }

        private void LoadPaymentTypes()
        {
            cmbPaymentType.DataSource = Factory.PaymentTypesController().Fetch();
            cmbPaymentType.DisplayMember = "name";
            cmbPaymentType.ValueMember = "id";
        }

        private void CreateColumns()
        {
            dgItems.ColumnCount = 9;
            dgItems.Columns[0].Name = "ItemId";
            dgItems.Columns[1].Name = "StoreId";
            dgItems.Columns[2].Name = "Store";
            dgItems.Columns[3].Name = "Item";
            dgItems.Columns[4].Name = "Unit";
            dgItems.Columns[5].Name = "Price";
            dgItems.Columns[6].Name = "Quantity";
            dgItems.Columns[7].Name = "Total";
            dgItems.Columns[8].Name = "UnitCost";

            dgItems.Columns["ItemId"].Visible = false;
            dgItems.Columns["StoreId"].Visible = false;
            dgItems.Columns["UnitCost"].Visible = false;
            dgItems.Columns["Item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

    }
}
