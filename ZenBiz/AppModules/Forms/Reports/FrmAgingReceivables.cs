using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmAgingReceivables : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmAgingReceivables()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void LoadCustomers()
        {
            Dictionary<int, string> customerDict = new();
            DataTable dtCustomers = Factory.CustomersController().Fetch();
            customerDict.Add(0, "All");
            foreach (DataRow item in dtCustomers.Rows)
                customerDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbCustomers.DataSource = new BindingSource(customerDict, null);
            cmbCustomers.DisplayMember = "Value";
            cmbCustomers.ValueMember = "key";
        }

        private void LoadCustomersTransactions()
        {
            Dictionary<int, string> customerSalesTransactionDict = new();
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);

            DataTable dtCustomersSalesTransaction = Factory.SalesController().FetchByCustomerID(customerID);
            customerSalesTransactionDict.Add(0, "All");
            foreach (DataRow item in dtCustomersSalesTransaction.Rows)
                customerSalesTransactionDict.Add(Convert.ToInt32(item["id"]), item["trans_no"].ToString());

            cmbTransactionNo.DataSource = new BindingSource(customerSalesTransactionDict, null);
            cmbTransactionNo.DisplayMember = "Value";
            cmbTransactionNo.ValueMember = "key";
        }

        private void FrmAgingReceivables_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCustomersTransactions();
        }

        private DataTable DataTableAgingReceivables()
        {
            DataTable dataTableFromDB;
            var dtReport = new DataSet1.AgingReceivableDataTable();
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            int salesID = Convert.ToInt32(cmbTransactionNo.SelectedValue);

            dataTableFromDB = Factory.SalesItemController().FetchBySalesIdPerCustomer(salesID, customerID);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                int saleID = Convert.ToInt32(item["sales_id"]);
                decimal balance = Factory.PaymentsController().BalanceAmount(saleID);

                if (balance == 0)
                    break;

                decimal totalPayments = Factory.PaymentsController().SumTotalPaymentsPerSalesId(saleID);
                DataRow row = dtReport.NewRow();

                row["customer_name"] = item["customer_name"];
                row["transaction_number"] = item["trans_no"];
                row["transaction_date"] = item["trans_date"];
                row["total"] = totalPayments + balance;
                row["outstanding"] = balance;

                DateTime transDate = Convert.ToDateTime(item["trans_date"]);
                DateTime todaysDate = DateTime.Now;
                int daysCount = Convert.ToInt32((todaysDate - transDate).TotalDays);

                if (daysCount <= 30)
                    row["thirty_days"] = balance;
                else if (daysCount <= 60 && daysCount >= 31)
                    row["sixty_days"] = balance;
                else if (daysCount <= 90 && daysCount > 60)
                    row["ninety_days"] = balance;
                else if (daysCount > 90)
                    row["over_ninety_days"] = balance;

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }

        private void LoadReport(LocalReport report)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var dict = Factory.BusinessDetailsController().FindById(1);
                var parameters = new[] {
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                    new ReportParameter("paramCustomerName", cmbCustomers.Text),
                    new ReportParameter("paramTransactionNo", cmbTransactionNo.Text),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\aging-accounts-receivables.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("AgingReceivable", DataTableAgingReceivables()));
                report.SetParameters(parameters);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport(reportViewer.LocalReport);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }


        private void cmbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCustomersTransactions();
        }
    }
}
