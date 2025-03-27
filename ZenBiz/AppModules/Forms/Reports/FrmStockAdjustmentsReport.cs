using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System.Data;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmStockAdjustmentsReport : Form
    {
        private readonly bool _isWarehouse;
        private readonly ReportViewer reportViewer;

        public FrmStockAdjustmentsReport(bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _isWarehouse = isWarehouse;
            Text = $"{(_isWarehouse ? "Warehouse" : "Store")} Stock Adjustment Report";
            lblStoreWarehouseComboBoxText.Text = _isWarehouse ? "Warehouse" : "Store";

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void LoadStores()
        {
            cmbStoreWarehouse.DataSource = Factory.StoresController().Fetch();
            cmbStoreWarehouse.DisplayMember = "name";
            cmbStoreWarehouse.ValueMember = "id";
        }

        private void LoadWarehouses()
        {
            cmbStoreWarehouse.DataSource = Factory.WarehousesController().Fetch();
            cmbStoreWarehouse.DisplayMember = "name";
            cmbStoreWarehouse.ValueMember = "id";
        }

        private void FrmStockAdjustmentsReport_Load(object sender, EventArgs e)
        {
            if (_isWarehouse)
            {
                LoadWarehouses();
                return;
            }

            LoadStores();
        }

        private DataTable DataTableStocks()
        {
            var dtReport = new DataSet1.StockAdjustmentsDataTable();
            int storeWarehouseId = Convert.ToInt32(cmbStoreWarehouse.SelectedValue);
            DataTable dataTableFromDB;
            if (_isWarehouse)
                dataTableFromDB = Factory.WarehouseStockAdjustmentController().Fetch(storeWarehouseId, dtpFrom.Value, dtpTo.Value);
            else
                dataTableFromDB = Factory.StoreStockAdjustmentController().Fetch(storeWarehouseId, dtpFrom.Value, dtpTo.Value);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                DataRow row = dtReport.NewRow();
                row["sku_code"] = item["sku_code"];
                row["item_name"] = item["item_name"];
                row["unit"] = item["unit_name"];
                row["retail_price"] = item["retail_price"];
                row["wholesale_price"] = item["wholesale_price"];
                row["special_price"] = item["special_price"];
                row["adjusted_quantity"] = item["quantity"];
                row["date_adjusted"] = item["date_adjusted"];
                row["reasons"] = item["reason"];
                row["adjusted_by"] = item["created_by_user"];

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
                    new ReportParameter("paramStoreWarehouseName", cmbStoreWarehouse.Text),
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),

                    new ReportParameter("paramDateFrom", dtpFrom.Value.ToString("MMM dd, yyyy")),
                    new ReportParameter("paramDateTo", dtpTo.Value.ToString("MMM dd, yyyy")),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\stock-adjustments-report.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("StockAdjustments", DataTableStocks()));
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
