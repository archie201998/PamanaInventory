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
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            using FrmPurchasePaymentsAdd form = new(_purchaseId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //LoadPayments();
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
            dgPayments.Columns["ref_code"].HeaderText = "Reference Code";

            SumPayments();
        }
    }
}
