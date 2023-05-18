using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Payments;
using ZenBiz.AppModules.Forms.Sales;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchases : Form
    {
        public FrmPurchases()
        {
            InitializeComponent();
            Helper.FormDialogDefaults(this, true, true);
            Helper.DatagridDefaultStyle(dgPurchases, true);
            Helper.DatagridDefaultStyle(dgPurchasesItems, true);
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
            var purchaseDateFrom = dtpPurchasedDateFrom.Value;
            var purchaseDateTo = dtpPurchasedDateTo.Value;

            DataTable dtPurchases = Factory.PurchaseController().FetchByDatePeriod(purchaseDateFrom, purchaseDateTo);
            dtPurchases.Columns.Add("total_amount", typeof(decimal));
            dtPurchases.Columns.Add("amount_paid", typeof(decimal));
            dtPurchases.Columns.Add("balance", typeof(decimal));

            foreach (DataRow item in dtPurchases.Rows)
            {
                int purchaseId = Convert.ToInt32(item["id"]);
                int suppliersId = Convert.ToInt32(item["suppliers_id"]);
                DateTime purchasedDate = Convert.ToDateTime(item["purchase_date"]);

                decimal totalPurchase = Factory.PurchaseItemController().TotalAmountPerPurchased(purchaseId);
                decimal totalAmountPaid = Factory.PurchasePaymentsController().TotalAmountPaidPerPurchased(purchaseId);

                item["total_amount"] = totalPurchase;
                item["amount_paid"] = totalAmountPaid;
                item["balance"] = totalPurchase - totalAmountPaid;
            }

            dgPurchases.DataSource = dtPurchases;
            dgPurchases.Columns["id"].Visible = false;
            dgPurchases.Columns["suppliers_id"].Visible = false;
            dgPurchases.Columns["name"].HeaderText = "Supplier";
            dgPurchases.Columns["purchase_date"].HeaderText = "Purchased Date";
            dgPurchases.Columns["purchase_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgPurchases.Columns["total_amount"].HeaderText = "Total Amount";
            dgPurchases.Columns["total_amount"].DefaultCellStyle.Format = "N2";
            dgPurchases.Columns["total_amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPurchases.Columns["amount_paid"].HeaderText = "Amount Paid";
            dgPurchases.Columns["amount_paid"].DefaultCellStyle.Format = "N2";
            dgPurchases.Columns["amount_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPurchases.Columns["balance"].HeaderText = "Balance";
            dgPurchases.Columns["balance"].DefaultCellStyle.Format = "N2";
            dgPurchases.Columns["balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPurchases.CurrentCell = dgPurchases.FirstDisplayedCell;

            //SumTotalSales();
            //SumBalances();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPurchases.SelectedRows.Count == 0) return;
            int purchaseId = Convert.ToInt32(dgPurchases.SelectedCells[0].Value);
            FrmPurchasesEdit form = new(purchaseId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPurchases();
            }

            form.Dispose();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (dgPurchases.SelectedRows.Count == 0) return;

            int purchaseId = Convert.ToInt32(dgPurchases.SelectedCells[0].Value);
            using FrmPaymentPerPurchase form = new(purchaseId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPurchases();
            }
            form.Dispose();


        }

        private void FrmPurchases_Load(object sender, EventArgs e)
        {
            dgPurchases.SelectionChanged -= dgPurchases_SelectionChanged;
            LoadPurchases();
            dgPurchases.SelectionChanged += dgPurchases_SelectionChanged;

            if (dgPurchases.SelectedRows.Count == 1)
                LoadPurchasesItems();
            if (dgPurchases.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void dgPurchases_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgPurchases, btnEdit, btnDelete);

            if (dgPurchases.SelectedRows.Count == 1)
            {
                LoadPurchasesItems();
                btnPayments.Enabled = true;
                return;
            }

            btnPayments.Enabled = false;
        }

        private void LoadPurchasesItems()
        {
            int purchaseId = Convert.ToInt32(dgPurchases.SelectedCells[0].Value);
            dgPurchasesItems.DataSource = Factory.PurchaseItemController().FetchByPurchaseId(purchaseId);

            dgPurchasesItems.Columns["items_id"].Visible = false;
            dgPurchasesItems.Columns["unit_cost"].Visible = false;
            dgPurchasesItems.Columns["purchased_id"].Visible = false;

            dgPurchasesItems.Columns["name"].HeaderText = "Item";
            dgPurchasesItems.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgPurchasesItems.Columns["unit_name"].HeaderText = "Unit";
            dgPurchasesItems.Columns["purchased_amount"].HeaderText = "Amount";
            dgPurchasesItems.Columns["purchased_amount"].DefaultCellStyle.Format = "N2";
            dgPurchasesItems.Columns["purchased_amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPurchasesItems.Columns["purchased_quantity"].HeaderText = "Quantity";
            dgPurchasesItems.Columns["purchased_quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgPurchasesItems.Columns["total_purchased_amount"].HeaderText = "Total";
            dgPurchasesItems.Columns["total_purchased_amount"].DefaultCellStyle.Format = "N2";
            dgPurchasesItems.Columns["total_purchased_amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPurchases.SelectedRows.Count == 0) return;

            try
            {
                List<PurchasesModel> purchaseModelList = new();
                foreach (DataGridViewRow item in dgPurchases.SelectedRows)
                    purchaseModelList.Add(new PurchasesModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.PurchaseController().Delete(purchaseModelList);
                LoadPurchases();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPurchases();
        }

    }
}
