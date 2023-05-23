using Microsoft.Reporting.WinForms;
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
            int storeId = Convert.ToInt32(cmbCustomers.SelectedValue);
            if (storeId == 0)
                dataTableFromDB = Factory.SalesItemController().Fetch();
            else
                dataTableFromDB = Factory.SalesItemController().Fetch();

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                DataRow row = dtReport.NewRow();
                row["customer_name"] = item["customer_name"];
                row["total"] = item["total_sale"];
                row["outstanding"] = item["total_sale"];
                row["thirty_days"] = item["total_sale"];
                row["sixty_days"] = item["total_sale"];
                row["ninety_days"] = item["total_sale"];
                row["over_ninety_days"] = item["total_sale"];

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }

        private void LoadReport(LocalReport report)
        {
            try
            {
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
