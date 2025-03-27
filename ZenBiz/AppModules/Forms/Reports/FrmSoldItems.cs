using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmSoldItems : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmSoldItems()
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

        private void FrmSoldItems_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private DataTable DataTableSoldItems()
        {
            var dtReport = new DataSet1.SoldItemsDataTable();
            DataTable dataTableFromDB;
            DataTable dtSalesServices;

            int storeId = Convert.ToInt32(cmbStores.SelectedValue);
            if (storeId == 0)
            {
                dataTableFromDB = Factory.SalesItemController().FetchSoldItems(dtpFrom.Value, dtpTo.Value);
                dtSalesServices = Factory.SalesServicesController().FetchBetweenDates(dtpFrom.Value, dtpTo.Value);
            }
            else
            {
                dataTableFromDB = Factory.SalesItemController().FetchSoldItems(dtpFrom.Value, dtpTo.Value, storeId);
                dtSalesServices = Factory.SalesServicesController().FetchBetweenDatesAndStore(dtpFrom.Value, dtpTo.Value, storeId);
            }


            foreach (DataRow item in dataTableFromDB.Rows)
            {
                DataRow row = dtReport.NewRow();
                row["sku_code"] = item["sku_code"];
                row["item_name"] = item["item_name"];
                row["category"] = item["category_name"];
                row["unit"] = item["unit_name"];
                row["sold_quantity"] = item["sold_quantity"];
                row["sold_price"] = item["sold_price"];
                row["total_sale"] = item["gross_sale"];

                dtReport.Rows.Add(row);
            }
            // for sales services
            foreach (DataRow salesServicesItem in dtSalesServices.Rows)
            {
                DataRow row = dtReport.NewRow();
                row["sku_code"] = string.Empty;
                row["item_name"] = salesServicesItem["services_name"];
                row["category"] = "Services";
                row["unit"] = string.Empty;
                row["sold_quantity"] = 0;
                row["sold_price"] = salesServicesItem["fee"];
                row["total_sale"] = salesServicesItem["fee"];

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }

        private void LoadReport(LocalReport report)
        {
            var dict = Factory.BusinessDetailsController().FindById(1);
            var parameters = new[]
            {
                new ReportParameter("paramBusinessName", dict["name"]),
                new ReportParameter("paramAddress", dict["address"]),
                new ReportParameter("paramPermitNo", dict["permit_no"]),
                new ReportParameter("paramTIN", dict["tin"]),
                new ReportParameter("paramDateFrom", dtpFrom.Value.ToString("MMM dd, yyyy")),
                new ReportParameter("paramDateTo", dtpTo.Value.ToString("MMM dd, yyyy")),
                new ReportParameter("paramStoreName", cmbStores.Text)
            };

            report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\sold-items.rdlc";
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("SoldItems", DataTableSoldItems()));
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
