using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Payments
{
    public partial class FrmPaymentsPerSale : Form
    {
        private readonly int _salesId;

        public FrmPaymentsPerSale(int salesId)
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgPayments, true);
            Helper.FormDialogDefaults(this, false, false);
            _salesId = salesId;
        }

        private void LoadData()
        {
            var dict = Factory.SalesController().FindById(_salesId);
            if (dict.Count == 0) return;
            txtTransactionNo.Text = dict["trans_no"];
            txtTransactionDate.Text = Convert.ToDateTime(dict["trans_date"]).ToString("MMMM dd, yyyy");
            txtCustomer.Text = dict["customer_name"];
            txtBalance.Text = Factory.PaymentsController().BalanceAmount(_salesId).ToString("n2");
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
            dgPayments.DataSource = Factory.PaymentsController().FetchbySalesId(_salesId);
            dgPayments.Columns["id"].Visible = false;
            dgPayments.Columns["payment_types_id"].Visible = false;
            dgPayments.Columns["amount"].HeaderText = "Amount";
            dgPayments.Columns["amount"].DefaultCellStyle.Format = "N2";
            dgPayments.Columns["date_paid"].HeaderText = "Date Paid";
            dgPayments.Columns["date_paid"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgPayments.Columns["ref_code"].HeaderText = "Reference Code";

            SumPayments();
        }

        private void FrmPaymentsPerSale_Load(object sender, EventArgs e)
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
            using FrmPaymentsAdd form = new(_salesId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadPayments();
                LoadData();
            }
            form.Dispose();
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (dgPayments.SelectedRows.Count == 0) return;
            int paymentId = Convert.ToInt32(dgPayments.SelectedCells[0].Value);
            using FrmPaymentsEdit form = new(paymentId);
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
                List<PaymentsModel> paymentsModelList = new();
                foreach (DataGridViewRow item in dgPayments.SelectedRows)
                    paymentsModelList.Add(new PaymentsModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.PaymentsController().Delete(paymentsModelList);
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

        private void dgPayments_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgPayments, btnEditPayment, btnDeletePayment);
        }

        private void FrmPaymentsPerSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
