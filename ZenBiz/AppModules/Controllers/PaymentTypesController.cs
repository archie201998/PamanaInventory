using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PaymentTypesController : IPaymentTypes
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPaymentTypes = "payment_types";

        public PaymentTypesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PaymentTypesModel> entityList)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name FROM {tblPaymentTypes}";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PaymentTypesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaymentTypesModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
