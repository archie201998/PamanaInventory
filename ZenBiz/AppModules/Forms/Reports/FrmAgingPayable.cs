using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Reporting.WinForms;
using PamanaWaterInventory.AppModules.RDLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmAgingPayable : Form
    {
        private readonly ReportViewer reportViewer;
        public FrmAgingPayable()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void FrmAgingPayable_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            Dictionary<int, string> supplierDict = new();
            DataTable dtCustomers = Factory.SuppliersController().Fetch();
            supplierDict.Add(0, "All");
            foreach (DataRow item in dtCustomers.Rows)
                supplierDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbSuppliers.DataSource = new BindingSource(supplierDict, null);
            cmbSuppliers.DisplayMember = "Value";
            cmbSuppliers.ValueMember = "key";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport(reportViewer.LocalReport);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void LoadReport(LocalReport report)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                var dict = Factory.BusinessDetailsController().FindById(1);
                var parameters = new[] {
                    new ReportParameter("paramBusinessName", dict["name"]),
                    new ReportParameter("paramAddress", dict["address"]),
                    new ReportParameter("paramPermitNo", dict["permit_no"]),
                    new ReportParameter("paramTIN", dict["tin"]),
                    new ReportParameter("paramSupplierName", cmbSuppliers.Text),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\aging-accounts-payable.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("AgingPayable", DataTableAgingPayables()));
                report.SetParameters(parameters);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private DataTable DataTableAgingPayables()
        {
            DataTable dataTableFromDB;
            var dtReport = new DataSet1.AgingPayableDataTable();
            int suppliersID = Convert.ToInt32(cmbSuppliers.SelectedValue);

          
            dataTableFromDB = Factory.PurchaseController().FetchBySupplierID(suppliersID);

            foreach (DataRow item in dataTableFromDB.Rows)
            {
                int purchasesID = Convert.ToInt32(item["id"]);
                decimal balance = Factory.PurchasePaymentsController().BalanceAmountPerPurchased(purchasesID);

                if (balance == 0)
                    break;

                decimal totalPurchasedPayments = Factory.PurchasePaymentsController().TotalAmountPaidPerPurchased(purchasesID);
                DataRow row = dtReport.NewRow();

                row["total"] = totalPurchasedPayments + balance;
                row["supplier_name"] = item["name"];
                row["purchased_date"] = Convert.ToDateTime(item["purchase_date"]);

                DateTime transDate = Convert.ToDateTime(item["purchase_date"]);
                DateTime todaysDate = DateTime.Now;
                int daysCount = Convert.ToInt32((todaysDate - transDate).TotalDays);

                if (daysCount <= 30)
                    row["thirty_days"] = balance;
                else if (daysCount <= 60 && daysCount >= 31)
                    row["sixty_days"] = balance;
                else if (daysCount <= 90 && daysCount > 60)
                    row["ninety_days"] = balance;
                else if (daysCount > 90)
                    row["over_ninety_days"] = balance;

                dtReport.Rows.Add(row);
            }

            return dtReport;
        }
    }
}
