using Microsoft.Reporting.WinForms;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmStockPerWarehouseReport : Form
    {
        private readonly ReportViewer reportViewer;

        public FrmStockPerWarehouseReport()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void LoadWarehouses()
        {
            cmbWarehouses.DataSource = Factory.WarehousesController().Fetch();
            cmbWarehouses.DisplayMember = "name";
            cmbWarehouses.ValueMember = "id";
        }

        private void LoadCategories()
        {
            Dictionary<int, string> dict = new();
            DataTable dt = Factory.CategoriesController().Fetch();
            dict.Add(0, "All");
            foreach (DataRow item in dt.Rows)
            {
                dict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());
            }
            cmbCategories.DataSource = new BindingSource(dict, null);
            cmbCategories.DisplayMember = "Value";
            cmbCategories.ValueMember = "Key";
        }

        private void FrmStockPerWarehouseReport_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
            LoadCategories();
        }

        private DataTable DataTableStocks()
        {
            var dtReport = new DataSet1.StocksPerStoreDataTable();
            int warehousesId = Convert.ToInt32(cmbWarehouses.SelectedValue);
            int categoriesId = Convert.ToInt32(cmbCategories.SelectedValue);
            DataTable dataTableFromDB;
            if (categoriesId == 0)
                dataTableFromDB = Factory.ItemsController().Fetch();
            else
                dataTableFromDB = Factory.ItemsController().Fetch(categoriesId);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                decimal stocksLeft = Factory.WarehouseStocksController().SumTotalStocks(warehousesId, Convert.ToInt32(item["id"]));
                DataRow row = dtReport.NewRow();
                row["sku_code"] = item["sku_code"];
                row["item_name"] = item["name"];
                row["category"] = item["category_name"];
                row["unit"] = item["unit_name"];
                row["retail_price"] = item["retail_price"];
                row["wholesale_price"] = item["wholesale_price"];
                row["special_price"] = item["special_price"];
                row["stocks_left"] = stocksLeft;

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
                    new ReportParameter("paramWarehouseName", cmbWarehouses.Text),
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\stocks-per-warehouse.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("StocksPerWarehouse", DataTableStocks()));
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
