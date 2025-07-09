using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamanaWaterInventory.AppModules.Models
{
    internal class StockUserHistoryModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int BranchID { get; set; }
        public int StockID { get; set; }
        public bool IsCurrentUser { get; set; }
    }
}
