using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmSalesDueReport : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmSalesDueReport()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void LoadMonth()
        {
            Dictionary<int, string> dict = new()
            {
                { 1, "January" },
                { 2, "February" },
                { 3, "March" },
                { 4, "April" },
                { 5, "May" },
                { 6, "June" },
                { 7, "July" },
                { 8, "August" },
                { 9, "September" },
                { 10, "October" },
                { 11, "November" },
                { 12, "December" }
            };
            cmbMonth.DataSource = new BindingSource(dict, null);
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "key";
        }

        private void FrmSalesDueReport_Load(object sender, EventArgs e)
        {
            LoadMonth();
            nudYear.Value = DateTime.Now.Year;
        }

        private DataTable DataTableSalesDue()
        {
            DataTable dataTableFromDB;
            var dtReport = new DataSet1.SalesDueReportDataTable();
            int monthId = Convert.ToInt32(cmbMonth.SelectedValue);
            int year = (int)nudYear.Value;

            dataTableFromDB = Factory.SalesController().FetchSalesDue(monthId, year);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                int saleId = Convert.ToInt32(item["id"]);
                decimal balance = Factory.PaymentsController().BalanceAmount(saleId);

                if (balance == 0)
                    break;

                //decimal totalPayments = Factory.PaymentsController().SumTotalPaymentsPerSalesId(saleId);
                DataRow row = dtReport.NewRow();

                row["customer_name"] = item["customer_name"];
                row["trans_no"] = item["trans_no"];
                row["trans_date"] = Convert.ToDateTime(item["trans_date"]).ToString("MMM dd, yyyy");
                row["trans_due_date"] = Convert.ToDateTime(item["trans_due_date"]).ToString("MMM dd, yyyy");
                //row["total"] = totalPayments + balance;
                row["balance_amount"] = balance;

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }

        private void LoadReport(LocalReport report)
        {
            var dict = Factory.BusinessDetailsController().FindById(1);
            var parameters = new[] {
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                    new ReportParameter("paramMonth", cmbMonth.Text),
                };

            report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\sales-due.rdlc";
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("SalesDueReport", DataTableSalesDue()));
            report.SetParameters(parameters);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadReport(reportViewer.LocalReport);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
            Cursor.Current = Cursors.Default;
        }
    }
}
