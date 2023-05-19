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

        private void LoadStores()
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

        private void FrmAgingReceivables_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private DataTable DataTableAgingReceivables()
        {
            DataTable dataTableFromDB;
            var dtReport = new DataSet1.GrossIncomeDataTable();
            int storeId = Convert.ToInt32(cmbCustomers.SelectedValue);
            if (storeId == 0)
                dataTableFromDB = Factory.SalesItemController().Fetch();
            else
                dataTableFromDB = Factory.SalesItemController().Fetch();

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                DataRow row = dtReport.NewRow();
                row[""] = item["customer_name"];
                row[""] = item["total"];
                row[""] = item["outstanding"];
                row[""] = item["thirty_days"];
                row[""] = item["sixty_days"];
                row[""] = item["ninety_days"];
                row[""] = item["over_ninety_days"];

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
                    new ReportParameter("paramStoreName", cmbCustomers.Text),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\aging-accounts-receivables.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("GrossIncome", DataTableAgingReceivables()));
                report.SetParameters(parameters);
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

    }
}
