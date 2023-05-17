using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenBiz.AppModules.Models
{
    internal class PurchasesModel
    {
        public int Id { get; set; }
        public SupplierModel Supplier { get; set; } = new();
        public DateTime TransactionDate { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
