using Microsoft.Reporting.WinForms;
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
    public partial class FrmStatementOfAccount : Form
    {
        private readonly ReportViewer reportViewer;

        private string customerContactInfo, customerAddress = string.Empty;

        public FrmStatementOfAccount()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer);
        }

        private void FrmStatementOfAccount_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCustomersTransactions();
        }

        private void SetCustomerInfo()
        {
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            Dictionary<string, string> customerDict = Factory.CustomersController().FindById(customerID);

            if (customerDict.Count == 0)
                return;

            customerAddress = customerDict["address"];
            customerContactInfo = customerDict["contact_info"];
        }

        private void LoadCustomers()
        {
            Dictionary<int, string> customerDict = new();
            DataTable dtCustomers = Factory.CustomersController().Fetch();
            foreach (DataRow item in dtCustomers.Rows)
                customerDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbCustomers.DataSource = new BindingSource(customerDict, null);
            cmbCustomers.DisplayMember = "Value";
            cmbCustomers.ValueMember = "key";
            SetCustomerInfo();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport(reportViewer.LocalReport);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
            SetCustomerInfo();
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
                    new ReportParameter("paramCustomerName", cmbCustomers.Text),
                    new ReportParameter("paramCustomerAddress", customerAddress),
                    new ReportParameter("paramCustomerContactInfo", customerContactInfo),
                    new ReportParameter("paramTransactionNumber", cmbTransactionNo.Text),
                };

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\statement-of-account.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("StatementOfAccount", DataTableStatmentOfAccount()));
                report.SetParameters(parameters);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private DataTable DataTableStatmentOfAccount()
        {
            var dtReport = new DataSet1.StatementOfAccountDataTable();
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            string transactionNo = cmbTransactionNo.Text;

            DataTable dtSalesByTransaction = Factory.SalesController().FetchByTransactionNo(transactionNo);
            DataTable dtSalesByCustomer = Factory.SalesController().FetchByCustomerID(customerID);

            DataTable dtSales = transactionNo == "All" ? dtSalesByCustomer : dtSalesByTransaction;

            foreach (DataRow item in dtSales.Rows)
            {
                DataRow row = dtReport.NewRow();

                if (transactionNo == "All")
                    row["transaction_no"] = item["trans_no"];
              
                row["transaction_date"] = Convert.ToDateTime(item["trans_date"]);

                string transactionDetails = string.Empty;
                DataTable dtTransactionItems = Factory.SalesItemController().FetchBySalesId(Convert.ToInt32(item["id"]));

                foreach (DataRow transactionItems in dtTransactionItems.Rows)
                {
                    transactionDetails += $"{transactionItems["item_name"]} - (₱ {transactionItems["sold_price"]} x {transactionItems["sold_quantity"]} {transactionItems["unit_name"]})@";
                }

                transactionDetails = transactionDetails.Replace("@", Environment.NewLine);
                decimal payments = Factory.PaymentsController().SumTotalPaymentsPerSalesId(Convert.ToInt32(item["id"]));
                decimal balance = Factory.PaymentsController().BalanceAmount(Convert.ToInt32(item["id"]));

                row["transaction_details"] = transactionDetails.Replace(Environment.NewLine, Environment.NewLine + Environment.NewLine);
                row["amount"] = payments + balance;
                row["payments"] = payments;
                row["balance"] = balance;


                dtReport.Rows.Add(row);

            }


            return dtReport;
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

        private void cmbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetCustomerInfo();
            LoadCustomersTransactions();
        }
    }
}
