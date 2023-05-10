using Microsoft.Reporting.WinForms;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmGrossIncomeReport : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmGrossIncomeReport()
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

        private void FrmGrossIncomeReport_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private DataTable DataTableGrossIncome()
        {
            DataTable dataTableFromDB;
            var dtReport = new DataSet1.GrossIncomeDataTable();
            int storeId = Convert.ToInt32(cmbStores.SelectedValue);
            if (storeId == 0)
                dataTableFromDB = Factory.SalesItemController().Fetch(dtpFrom.Value, dtpTo.Value);
            else
                dataTableFromDB = Factory.SalesItemController().Fetch(dtpFrom.Value, dtpTo.Value, storeId);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                decimal grossSale = Convert.ToDecimal(item["gross_sale"]);
                decimal unitCost = Helper.UserType == "Staff" ? 0 : Convert.ToDecimal(item["sold_unit_cost"]);
                DataRow row = dtReport.NewRow();
                row["trans_no"] = item["trans_no"];
                row["trans_date"] = Convert.ToDateTime(item["trans_date"]).ToString("MMM dd, yyyy");
                row["customer_name"] = item["customer_name"];
                row["sold_price"] = item["sold_price"];
                row["sold_quantity"] = item["sold_quantity"];
                row["sold_unit_cost"] = unitCost;
                row["total_sale"] = grossSale - unitCost;
                row["sku_code"] = item["sku_code"];
                row["item_name"] = item["item_name"];
                row["unit_name"] = item["unit_name"];

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
                    new ReportParameter("paramDateFrom", dtpFrom.Value.ToString("MMM dd, yyyy")),
                    new ReportParameter("paramDateTo", dtpTo.Value.ToString("MMM dd, yyyy")),
                    new ReportParameter("paramStoreName", cmbStores.Text),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\gross-income.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("GrossIncome", DataTableGrossIncome()));
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
