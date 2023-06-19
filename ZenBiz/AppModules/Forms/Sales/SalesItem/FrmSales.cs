using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Forms.Payments;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Sales
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.FormDialogDefaults(this, true, true);
            Helper.DatagridDefaultStyle(dgSales, true);
            Helper.DatagridDefaultStyle(dgSalesItems);
            Helper.DatagridDefaultStyle(dgSalesServices);
        }

        private void SumTotalSales()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgSales.Rows)
            {
                total += Convert.ToDecimal(item.Cells["total_sales"].Value);
            }

            txtTotalSales.Text = total.ToString("n2");
        }

        private void SumBalances()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgSales.Rows)
            {
                total += Convert.ToDecimal(item.Cells["balance"].Value);
            }

            txtCollectibles.Text = total.ToString("n2");
        }

        private void LoadSales()
        {
            DataTable dtSales = Factory.SalesController().Fetch(dtpTransactionDate.Value);
            dtSales.Columns.Add("total_sales", typeof(decimal));
            dtSales.Columns.Add("amount_paid", typeof(decimal));
            dtSales.Columns.Add("balance", typeof(decimal));
            foreach (DataRow item in dtSales.Rows)
            {
                int salesId = Convert.ToInt32(item["id"]);

                decimal grossSalesServices = Factory.SalesServicesController().GrossSales(salesId);
                decimal grossSalesItems = Factory.SalesItemController().GrossSales(salesId);
                decimal totalSale = grossSalesServices + grossSalesItems;

                decimal totalAmountPaid = Factory.PaymentsController().SumTotalPaymentsPerSalesId(salesId);
                item["total_sales"] = totalSale.ToString("n2");
                item["amount_paid"] = totalAmountPaid.ToString("n2");
                item["balance"] = totalSale - totalAmountPaid;
            }

            dgSales.DataSource = dtSales;
            dgSales.Columns["id"].Visible = false;
            dgSales.Columns["customers_id"].Visible = false;
            dgSales.Columns["trans_no"].HeaderText = "Transaction No.";
            dgSales.Columns["trans_date"].HeaderText = "Date";
            dgSales.Columns["trans_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgSales.Columns["customer_name"].HeaderText = "Customer";
            dgSales.Columns["total_sales"].HeaderText = "Total Sale";
            dgSales.Columns["total_sales"].DefaultCellStyle.Format = "N2";
            dgSales.Columns["total_sales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.Columns["total_sales"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.Columns["amount_paid"].HeaderText = "Amount Paid";
            dgSales.Columns["amount_paid"].DefaultCellStyle.Format = "N2";
            dgSales.Columns["amount_paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.Columns["amount_paid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.Columns["balance"].HeaderText = "Balance";
            dgSales.Columns["balance"].DefaultCellStyle.Format = "N2";
            dgSales.Columns["balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.Columns["balance"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSales.CurrentCell = dgSales.FirstDisplayedCell;


            SumTotalSales();
            SumBalances();
        }


        private void LoadSalesItems()
        {
            int salesId = Convert.ToInt32(dgSales.SelectedCells[0].Value);
            dgSalesItems.DataSource = Factory.SalesItemController().FetchBySalesId(salesId);
            dgSalesItems.Columns["id"].Visible = false;
            dgSalesItems.Columns["items_id"].Visible = false;
            dgSalesItems.Columns["stores_id"].Visible = false;
            dgSalesItems.Columns["item_unit_cost"].Visible = false;
            dgSalesItems.Columns["unit_name1"].Visible = false;

            dgSalesItems.Columns["store_name"].HeaderText = "Store";
            dgSalesItems.Columns["item_name"].HeaderText = "Item";
            dgSalesItems.Columns["item_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSalesItems.Columns["unit_name"].HeaderText = "Unit";
            dgSalesItems.Columns["sold_unit_cost"].Visible = false;
            dgSalesItems.Columns["sold_unit_cost"].HeaderText = "Unit Cost";
            dgSalesItems.Columns["sold_price"].HeaderText = "Price";
            dgSalesItems.Columns["sold_price"].DefaultCellStyle.Format = "N2";
            dgSalesItems.Columns["sold_quantity"].HeaderText = "Quantity";
            dgSalesItems.Columns["total_sale"].HeaderText = "Total Sale";
            dgSalesItems.Columns["total_sale"].DefaultCellStyle.Format = "N2";
        }

        private void LoadSalesServices()
        {
            int salesId = Convert.ToInt32(dgSales.SelectedCells[0].Value);
            dgSalesServices.DataSource = Factory.SalesServicesController().FetchBySalesId(salesId);

            dgSalesServices.Columns["id"].Visible = false;
            dgSalesServices.Columns["sales_id"].Visible = false;
            dgSalesServices.Columns["services_id"].Visible = false;
            dgSalesServices.Columns["personnel_id"].Visible = false;
            dgSalesServices.Columns["services_name"].HeaderText = "Service";
            dgSalesServices.Columns["personnel_name"].HeaderText = "Personnel";
            dgSalesServices.Columns["fee"].HeaderText = "Fee";
            dgSalesServices.Columns["fee"].DefaultCellStyle.Format = "N2";

            dgSalesServices.Columns["services_name"].MinimumWidth = 200;
            dgSalesServices.Columns["services_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            dgSales.SelectionChanged -= dgSales_SelectionChanged;
            LoadSales();
            dgSales.SelectionChanged += dgSales_SelectionChanged;

            if (dgSales.SelectedRows.Count == 1)
            {
                LoadSalesItems();
                LoadSalesServices();
            }

            if (dgSales.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dgSales_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgSales, btnEdit, btnDelete);

            if (dgSales.SelectedRows.Count == 1)
            {
                LoadSalesItems();
                LoadSalesServices();
                btnPayments.Enabled = true;
                return;
            }

            btnPayments.Enabled = false;
            dgSalesItems.DataSource = null;
            dgSalesItems.Rows.Clear();

        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSalesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadSales();
            }

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSales.SelectedRows.Count == 0) return;
            int salesId = Convert.ToInt32(dgSales.SelectedCells[0].Value);
            FrmSalesEdit form = new(salesId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadSales();
            }

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgSales.SelectedRows.Count == 0) return;

            try
            {
                List<SalesModel> salesModelList = new();
                foreach (DataGridViewRow item in dgSales.SelectedRows)
                    salesModelList.Add(new SalesModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.SalesController().Delete(salesModelList);
                LoadSales();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (dgSales.SelectedRows.Count == 0) return;
            int salesId = Convert.ToInt32(dgSales.SelectedCells[0].Value);
            using FrmPaymentsPerSale form = new(salesId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadSales();
            }
            form.Dispose();
        }
    }
}
