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
using ZenBiz.AppModules.Controllers;
using ZenBiz.AppModules.RDLC;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmStatementOfAccount : Form
    {
        private readonly ReportViewer reportViewer;
        private int _salesID = 0;

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

                DataTable dtReportSource = new();
                string reportDataSourceName = string.Empty;
                string reportRDLCSource = string.Empty;

                report.DataSources.Clear();
                if (cmbTransactionNo.Text == "All")
                {
                    dtReportSource = DataTableStatementOfAccountPerCustomer();
                    reportDataSourceName = "StatementOfAccountPerCustomer";
                    reportRDLCSource = "statement-of-account-by-customer.rdlc";
                }
                else //per transaction
                {
                    dtReportSource = DataTableStatmentOfAccountPerTransaction();
                    reportDataSourceName = "StatementOfAccountPerTransaction";
                    reportRDLCSource = "statement-of-account-by-transaction.rdlc";
                    report.DataSources.Add(new ReportDataSource("StatementOfAccountPerTransactionDetails", DataTableStatmentOfAccountPerTransactionDetails()));
                }

                report.ReportPath = $"{Application.StartupPath}\\AppModules\\RDLC\\{reportRDLCSource}";
                report.DataSources.Add(new ReportDataSource(reportDataSourceName, dtReportSource));
                report.SetParameters(parameters);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }
        }

        private DataTable DataTableStatementOfAccountPerCustomer()
        {
            var dtReport = new DataSet1.StatementOfAccountDataTable();
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            
            DataTable dtSalesByCustomer = Factory.SalesController().FetchByCustomerID(customerID);

            foreach (DataRow item in dtSalesByCustomer.Rows)
            {
                DataRow row = dtReport.NewRow();
                int salesID = Convert.ToInt32(item["id"]);

                decimal payments = Factory.PaymentsController().SumTotalPaymentsPerSalesId(salesID);
                decimal balance = Factory.PaymentsController().BalanceAmount(salesID);

                row["transaction_date"] = Convert.ToDateTime(item["trans_date"]);
                row["amount"] = payments + balance;
                row["transaction_no"] = item["trans_no"];
                row["payments"] = payments;
                row["balance"] = balance;

                dtReport.Rows.Add(row);

            }


            return dtReport;

        }

        private DataTable DataTableStatmentOfAccountPerTransaction()
        {
            var dtReport = new DataSet1.StatementOfAccountDataTable();
            string transactionNumber = cmbTransactionNo.Text;

            Dictionary<string, string> salesDict = Factory.SalesController().FetchByTransactionNo(transactionNumber);
            int salesID = Convert.ToInt32(salesDict["id"]);
            _salesID = salesID;

            DataTable  dtCustomerPayments = Factory.PaymentsController().FetchbySalesId(salesID);
            decimal balance = Factory.SalesItemController().GrossSales(salesID);

            foreach (DataRow item in dtCustomerPayments.Rows)
            {
                DataRow row = dtReport.NewRow();
                row["transaction_date"] = item["date_paid"].ToString();
                row["payment_type"] = item["payment_type"].ToString();
                row["payments"] = Convert.ToDecimal(item["amount"]); 
                row["balance"] = balance -= Convert.ToDecimal(item["amount"]);

                dtReport.Rows.Add(row);
            }


            return dtReport;
        }

        private DataTable DataTableStatmentOfAccountPerTransactionDetails()
        {
            var dtReportDetails = new DataSet1.StatementOfAccountTransactionDetailsDataTable();
            DataTable dtTransactionItems = Factory.SalesItemController().FetchBySalesId(_salesID);

            foreach (DataRow transactionItems in dtTransactionItems.Rows)
            {
                DataRow rowDetails = dtReportDetails.NewRow();

                decimal soldPrice = Convert.ToDecimal(transactionItems["sold_price"]);
                int soldQuatity = Convert.ToInt32(transactionItems["sold_quantity"]);

                rowDetails["details"] = transactionItems["item_name"];
                rowDetails["quantity"] = $"{soldQuatity} {transactionItems["unit_name"]}";
                rowDetails["amount"] = soldPrice * soldQuatity;
                dtReportDetails.Rows.Add(rowDetails);
            }

            return dtReportDetails;
        }

    }
}
