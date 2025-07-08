using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.UserHistory
{
    public partial class ucStockUserHistory : UserControl
    {
        public ucStockUserHistory()
        {
            InitializeComponent();
        }

        private void ucStockUserHistory_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateReturned.Enabled = checkBox1.Checked;    
        }
    }
}
