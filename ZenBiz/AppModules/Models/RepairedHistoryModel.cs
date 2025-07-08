using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Models
{
    internal class RepairedHistoryModel
    {
        public int Id { get; set; }
        public string ReportedBy { get; set; }
        public string IssueDescription { get; set; }
        public string RepairedAction { get; set; }
        public DateTime RepairedDate { get; set; }
        public string RepairedBy { get; set; }
        public decimal RepairedCost { get; set; }
        public string OtherDetails { get; set; }
        public int StockID { get; set; }
    }
}
