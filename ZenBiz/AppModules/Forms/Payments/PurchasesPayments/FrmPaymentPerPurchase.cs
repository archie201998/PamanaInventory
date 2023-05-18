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
using ZenBiz.AppModules.Forms.Payments.PurchasesPayments;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

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

        private void LoadData()
        {
            var dict = Factory.PurchaseController().FindById(_purchaseId);
            if (dict.Count == 0) return;

            txtTransactionDate.Text = Convert.ToDateTime(dict["purchase_date"]).ToString("MMMM dd, yyyy");
            txtSupplier.Text = dict["name"];
            txtTotalAmount.Text = Factory.PurchasePaymentsController().TotalAmountPaidPerPurchased(_purchaseId).ToString("N2");
            txtBalance.Text = Factory.PurchasePaymentsController().BalanceAmountPerPurchased(_purchaseId).ToString("N2");
        }

        private void FrmPaymentPerPurchase_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadPayments();

            if (dgPayments.Rows.Count == 0)
            {
                btnEditPayment.Enabled = false;
                btnDeletePayment.Enabled = false;
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            using FrmPurchasePaymentsAdd form = new(_purchaseId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPayments();
                LoadData();
            }
            form.Dispose();
        }
        private void SumPayments()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgPayments.Rows)
                total += Convert.ToDecimal(item.Cells["amount"].Value);

            lblTotalPayments.Text = total.ToString("n2");
        }


        private void LoadPayments()
        {
            dgPayments.DataSource = Factory.PurchasePaymentsController().FetchbyPurchaseId(_purchaseId);
            dgPayments.Columns["id"].Visible = false;
            dgPayments.Columns["payment_types_id"].Visible = false;
            dgPayments.Columns["amount"].HeaderText = "Amount";
            dgPayments.Columns["amount"].DefaultCellStyle.Format = "N2";
            dgPayments.Columns["date_paid"].HeaderText = "Date Paid";
            dgPayments.Columns["date_paid"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgPayments.Columns["ref_no"].HeaderText = "Reference Code";

            SumPayments();
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (dgPayments.SelectedRows.Count == 0) return;
            int paymentId = Convert.ToInt32(dgPayments.SelectedCells[0].Value);
            using FrmPurchasePaymentsEdit form = new(paymentId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPayments();
                LoadData();
            }
            form.Dispose();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgPayments.SelectedRows.Count == 0) return;

            try
            {
                List<PurchasePaymentModel> purchasePaymentModelList = new();
                foreach (DataGridViewRow item in dgPayments.SelectedRows)
                    purchasePaymentModelList.Add(new PurchasePaymentModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.PurchasePaymentsController().Delete(purchasePaymentModelList);
                LoadPayments();
                LoadData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void FrmPaymentPerPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgPayments_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgPayments, btnEditPayment, btnDeletePayment);
        }
    }
}
