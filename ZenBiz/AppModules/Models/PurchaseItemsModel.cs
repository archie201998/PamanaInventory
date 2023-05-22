using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenBiz.AppModules.Models
{
    internal class PurchaseItemsModel
    {
        public PurchasesModel Purchases { get; set; } = new();
        public ItemsModel Items { get; set; } = new();
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }

    }
}
