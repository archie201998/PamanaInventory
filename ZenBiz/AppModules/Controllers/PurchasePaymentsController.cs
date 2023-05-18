using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PurchasePaymentsController : IPurchasedPayments
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPurchasePayments = "purchase_payments";
        private const string viewPurchasePayments = "view_purchase_payments";

        public PurchasePaymentsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Insert(PurchasePaymentModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(PurchasePaymentModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PurchasePaymentModel> entityList)
        {
            throw new NotImplementedException();
        }
    }
}