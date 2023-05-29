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

            decimal balance = 0.0m;

            DataTable dtSales = Factory.SalesController().FetchByCustomerID(customerID);
            DataTable dtPayments;


            foreach (DataRow item in dtSales.Rows)
            {
                DataRow row = dtReport.NewRow();

                int salesID = Convert.ToInt32(item["id"]);
                dtPayments = Factory.PaymentsController().FetchbySalesId(salesID);

                balance += Factory.SalesItemController().GrossSales(salesID);

                row["transaction_date"] = Convert.ToDateTime(item["trans_date"]);
                row["transaction_details"] = "Transaction No." + item["trans_no"].ToString();
                row["transaction"] = "Invoice";
                row["amount"] = Factory.SalesItemController().GrossSales(salesID);
                row["payments"] = 0.0m;
                row["balance"] = balance;

                dtReport.Rows.Add(row);

                foreach (DataRow paymentItem in dtPayments.Rows)
                {
                    DataRow paymentRow = dtReport.NewRow();

                    paymentRow["transaction_date"] = Convert.ToDateTime(paymentItem["date_paid"]);
                    paymentRow["transaction_details"] = "Ref. Code " + paymentItem["ref_code"] + " : Payment for " + item["trans_no"];
                    paymentRow["transaction"] = "Payment";
                    paymentRow["amount"] = 0.0m;
                    paymentRow["payments"] = Convert.ToDecimal(paymentItem["amount"]);
                    paymentRow["balance"] = Factory.SalesItemController().GrossSales(salesID) - Convert.ToDecimal(paymentItem["amount"]);

                    balance -= Convert.ToDecimal(paymentItem["amount"]);
                    dtReport.Rows.Add(paymentRow);
                }

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
