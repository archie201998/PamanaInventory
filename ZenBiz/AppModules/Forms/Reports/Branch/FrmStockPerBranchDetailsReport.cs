using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System.Data;

namespace ZenBiz.AppModules.Forms.Reports.Store
{
    public partial class FrmStockPerBranchDetailsReport : Form
    {
        private readonly ReportViewer reportViewer;
        public FrmStockPerBranchDetailsReport()
        {
            InitializeComponent();

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void FrmStockAdjustmentStoreReport_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }
        private void LoadBranches()
        {
            cmbBranches.DataSource = Factory.BranchesController().Fetch();
            cmbBranches.DisplayMember = "name";
            cmbBranches.ValueMember = "id";
        }

        private DataTable DataTableStocks()
        {
            var dtReport = new DataSet1.StockPerBranchDetailsDataTable();
            int branchId = Convert.ToInt32(cmbBranches.SelectedValue);

            DataTable dataTableFromDB;

            dataTableFromDB = Factory.BranchStocksController().FetchBranchesStocksByBranchId(branchId);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                DataRow row = dtReport.NewRow();

                row["item_code"] = item["item_code"];   
                row["item_name"] = item["item_name"];
                row["category_name"] = item["category_name"];
                row["abbreviation"] = item["abbreviation"];
                row["serial_number"] = item["serial_number"];
                row["model"] = item["model"];
                row["operating_system"] = item["operating_system"];
                row["ram"] = item["ram"];
                row["computer_name"] = item["computer_name"];
                row["sophos_tamper"] = item["sophos_tamper"];
                row["date_acquired"] = item["date_acquired"];
                row["unit_cost"] = item["unit_cost"];
                row["status"] = item["status"];
                row["remarks"] = item["remarks"];
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
                    new ReportParameter("paramBranchName", cmbBranches.Text),
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\stocks-per-branch-details.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("StocksPerBranchDetails", DataTableStocks()));
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
    }
}
