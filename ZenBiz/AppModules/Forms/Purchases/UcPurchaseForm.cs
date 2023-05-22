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
            _ = new FrmPurchasesItemsSearch(this).ShowDialog();
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
        private void CreateColumns()
        {

            dgItems.ColumnCount = 6;
            dgItems.Columns[0].Name = "item_id";
            dgItems.Columns[1].Name = "item";
            dgItems.Columns[2].Name = "unit";
            dgItems.Columns[3].Name = "unit_cost";
            dgItems.Columns[4].Name = "quantity";
            dgItems.Columns[5].Name = "total";

            dgItems.Columns["item_id"].Visible = false;
            dgItems.Columns["item"].HeaderText = "Item";
            dgItems.Columns["unit"].HeaderText = "Unit";
            dgItems.Columns["unit_cost"].HeaderText = "Unit Cost";
            dgItems.Columns["quantity"].HeaderText = "Quantity";
            dgItems.Columns["total"].HeaderText = "Total";

            dgItems.Columns["unit_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgItems.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgItems.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgItems.Columns["item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadPaymentTypes()
        {
            cmbPaymentType.DataSource = Factory.PaymentTypesController().Fetch();
            cmbPaymentType.DisplayMember = "name";
            cmbPaymentType.ValueMember = "id";
        }

        internal void SumTotalPurchase()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgItems.Rows)
            {
                total += Convert.ToDecimal(item.Cells["total"].Value);
            }
            lblTotalPurchase.Text = total.ToString("N2");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgItems.SelectedRows)
                dgItems.Rows.Remove(item);
        }
    }
}
