using ZenBiz.AppModules.Forms.Components;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class UcSalesForm : UserControl
    {
        internal int CustomerId;

        public UcSalesForm()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgItems);
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epCustomer.GetError(txtCustomerName),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void SelectedCustomer(int customerId)
        {
            CustomerId = customerId;
            var dict = Factory.CustomersController().FindById(customerId);
            txtCustomerName.Text = dict["name"];
            txtCustomerAddress.Text = dict["address"];
            txtCustomerContactInfo.Text = dict["contact_info"];
        }

        private void CreateColumns()
        {
            dgItems.ColumnCount = 9;
            dgItems.Columns[0].Name = "ItemId";
            dgItems.Columns[1].Name = "StoreId";
            dgItems.Columns[2].Name = "Store";
            dgItems.Columns[3].Name = "Item";
            dgItems.Columns[4].Name = "Unit";
            dgItems.Columns[5].Name = "Price";
            dgItems.Columns[6].Name = "Quantity";
            dgItems.Columns[7].Name = "Total";
            dgItems.Columns[8].Name = "UnitCost";

            dgItems.Columns["ItemId"].Visible = false;
            dgItems.Columns["StoreId"].Visible = false;
            dgItems.Columns["UnitCost"].Visible = false;
            dgItems.Columns["Item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal void SumTotalSales()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgItems.Rows)
            {
                total += Convert.ToDecimal(item.Cells["Total"].Value);
            }
            lblTotalSales.Text = total.ToString("n2");
        }

        private void LoadPaymentTypes()
        {
            cmbPaymentType.DataSource = Factory.PaymentTypesController().Fetch();
            cmbPaymentType.DisplayMember = "name";
            cmbPaymentType.ValueMember = "id";
        }

        private void UcSalesForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CreateColumns();
                LoadPaymentTypes();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            using FrmCustomerSearch form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SelectedCustomer(form.CustomerId);
            }

            form.Dispose();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _ = new FrmItemSearch(this).ShowDialog();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgItems.SelectedRows)
                dgItems.Rows.Remove(item);

            SumTotalSales();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CustomerId = 0;
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtCustomerContactInfo.Clear();
        }

        private void chkPayment_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPayments.Enabled = chkPayment.Checked;
            cmbPaymentType.SelectedIndex = 0;
            txtRefCode.Clear();
            nudAmountPaid.Value = 0;

        }

    }
}
