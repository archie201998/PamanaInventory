using Microsoft.Reporting.WinForms;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmFastAndSlowMovingStocks : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmFastAndSlowMovingStocks()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void LoadStores()
        {
            Dictionary<int, string> storeDict = new();
            DataTable dtStores = Factory.StoresController().Fetch();
            storeDict.Add(0, "All");
            foreach (DataRow item in dtStores.Rows)
                storeDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbStores.DataSource = new BindingSource(storeDict, null);
            cmbStores.DisplayMember = "Value";
            cmbStores.ValueMember = "key";
        }

        private void FrmFastAndSlowMovingStocks_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private DataTable DataTableFastAndSlowMovingStocks()
        {
            DataTable dataTableFromDB;
            DataTable dtSalesItems;

            var dtReport = new DataSet1.FastAndSlowMovingStocksDataTable();
            int storeId = Convert.ToInt32(cmbStores.SelectedValue);
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;
            string sortType = radFastMoving.Checked ? radFastMoving.Tag.ToString() : radSlowMoving.Tag.ToString();

            dtSalesItems = Factory.SalesItemController().FetchFastAndSlowMovingStocks(storeId, dateFrom, dateTo, sortType);

            foreach (DataRow item in dtSalesItems.Rows)
            {
                DataRow row = dtReport.NewRow();
                //row["items_id"] = item["items_id"];
                row["sku_code"] = item["sku_code"];
                row["item_name"] = item["item_name"];
                row["quantity_sold"] = item["quantity_sold"];

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }

        private void LoadReport(LocalReport report)
        {
            try
            {
                var dict = Factory.BusinessDetailsController().FindById(1);
                string datePeriod = $"{dtpFrom.Value.ToString("MMMM dd, yyyy")} - {dtpTo.Value.ToString("MMMM dd, yyyy")}";
                string daysCount = $"{(dtpTo.Value - dtpFrom.Value).Days} days";
                var parameters = new[] {
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                    new ReportParameter("paramStoreName", cmbStores.Text),
                    new ReportParameter("paramDatePeriod", datePeriod),
                    new ReportParameter("paramNoOfDays", daysCount.ToString()),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\fast-and-slow-moving-stocks.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("FastAndSlowMovingStocks", DataTableFastAndSlowMovingStocks()));
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
