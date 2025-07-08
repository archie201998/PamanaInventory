using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    public partial class ucRepairHistory : UserControl
    {
        public ucRepairHistory()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            throw new NotImplementedException();
        }

        private void ucRepairHistory_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

            }
        }
    }
}
