using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
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
            DataTable dtSalesItem;
            DataTable dtSalesServices;

            var dtReport = new DataSet1.GrossIncomeDataTable();
            int storeId = Convert.ToInt32(cmbStores.SelectedValue);
            DataTable dtSales = Factory.SalesController().FetchBetweenDates(dtpFrom.Value, dtpTo.Value);

            foreach (DataRow item in dtSales.Rows)
            {
                int salesId = (int)item["id"];
                if (storeId == 0)
                {
                    dtSalesItem = Factory.SalesItemController().Fetch(salesId);
                    dtSalesServices = Factory.SalesServicesController().FetchBySalesId(salesId);
                }
                else
                {
                    dtSalesItem = Factory.SalesItemController().Fetch(salesId, storeId);
                    dtSalesServices = Factory.SalesServicesController().FetchBySalesIdAndStoreId(salesId, storeId);
                }

                // sales item
                foreach (DataRow salesItem in dtSalesItem.Rows)
                {
                    decimal grossSale = Convert.ToDecimal(salesItem["gross_sale"]);
                    decimal unitCost = Helper.UserType == "Staff" ? 0 : Convert.ToDecimal(salesItem["sold_unit_cost"]);

                    DataRow row = dtReport.NewRow();
                    row["trans_no"] = salesItem["trans_no"];
                    row["trans_date"] = Convert.ToDateTime(salesItem["trans_date"]).ToString("MMM dd, yyyy");
                    row["customer_name"] = salesItem["customer_name"];
                    row["sold_price"] = salesItem["sold_price"];
                    row["sold_quantity"] = salesItem["sold_quantity"];
                    row["sold_unit_cost"] = unitCost;
                    row["total_sale"] = grossSale;
                    row["sku_code"] = salesItem["sku_code"];
                    row["item_name"] = salesItem["item_name"];
                    row["unit_name"] = salesItem["unit_name"];
                    dtReport.Rows.Add(row);
                }

                // sales services
                foreach (DataRow salesServicesItem in dtSalesServices.Rows)
                {
                    DataRow serviceRow = dtReport.NewRow();
                    serviceRow["trans_no"] = salesServicesItem["trans_no"];
                    serviceRow["trans_date"] = Convert.ToDateTime(salesServicesItem["trans_date"]).ToString("MMM dd, yyyy");
                    serviceRow["customer_name"] = salesServicesItem["customer_name"];
                    serviceRow["sold_price"] = salesServicesItem["fee"];
                    serviceRow["sold_quantity"] = 1;
                    serviceRow["total_sale"] = salesServicesItem["fee"];
                    serviceRow["item_name"] = salesServicesItem["services_name"];
                    dtReport.Rows.Add(serviceRow);
                }
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
