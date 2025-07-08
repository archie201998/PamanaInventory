using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.UserHistory
{
    public partial class frmStockUserHistory : Form
    {
        readonly string _serialNumber = string.Empty;
        readonly int _stockId = 0;
        public frmStockUserHistory(int stockId, string serialNumber)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _serialNumber = serialNumber;
            _stockId = stockId;
        }

        private void frmStockUserHistory_Load(object sender, EventArgs e)
        {
            Helper.DatagridDefaultStyle(dgRepairHistory, false, true);
            this.Text = $"Item User History > {_serialNumber}";
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new frmAddStockUserHistory().ShowDialog();
        }
    }
}
