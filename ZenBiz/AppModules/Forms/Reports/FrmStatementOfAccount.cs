using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmStatementOfAccount : Form
    {

        AutoCompleteStringCollection customers = new AutoCompleteStringCollection();


        public FrmStatementOfAccount()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
        }

        private void FrmStatementOfAccount_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
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
    }
}
