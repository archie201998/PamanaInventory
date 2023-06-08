using ZenBiz.AppModules.Forms.Components;
using ZenBiz.AppModules.Forms.Sales.SalesServices;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class UcSalesForm : UserControl
    {
        internal int CustomerId;

        public UcSalesForm()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgItems);
            Helper.DatagridDefaultStyle(dgServices);
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

        private void CreateItemColumns()
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

        private void CreateServicesColumns()
        {
            dgServices.ColumnCount = 5;
            dgServices.Columns[0].Name = "ServiceId";
            dgServices.Columns[1].Name = "PersonnelId";
            dgServices.Columns[2].Name = "Service";
            dgServices.Columns[3].Name = "Personnel";
            dgServices.Columns[4].Name = "Fee";

            dgServices.Columns["ServiceId"].Visible = false;
            dgServices.Columns["PersonnelId"].Visible = false;

            dgServices.Columns["Personnel"].Width = 200;
            dgServices.Columns["Personnel"].MinimumWidth = 200;
            dgServices.Columns["Service"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal void SumTotalItemSales()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgItems.Rows)
            {
                total += Convert.ToDecimal(item.Cells["Total"].Value);
            }
            lblTotalItemSales.Text = total.ToString("n2");
            lblTotalSales.Text = (Convert.ToDecimal(lblTotalItemSales.Text) + Convert.ToDecimal(lblTotalServicesFee.Text)).ToString("n2");
        }

        internal void SumTotalServiceFee()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgServices.Rows)
            {
                total += Convert.ToDecimal(item.Cells["fee"].Value);
            }
            lblTotalServicesFee.Text = total.ToString("n2");
            lblTotalSales.Text = (Convert.ToDecimal(lblTotalItemSales.Text) + Convert.ToDecimal(lblTotalServicesFee.Text)).ToString("n2");
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
                CreateItemColumns();
                CreateServicesColumns();
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

            SumTotalItemSales();
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

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            _ = new FrmSalesServicesAdd(this).ShowDialog();
        }

        private void btnDeleteServices_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgServices.SelectedRows)
                dgServices.Rows.Remove(item);

            SumTotalServiceFee();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSales_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
