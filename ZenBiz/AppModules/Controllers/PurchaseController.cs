using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PurchaseController : IPurchases
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPurchase = "purchases";

        public PurchaseController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblPurchase}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
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

        public bool Insert(PurchasesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id != 0 ? entity.Supplier.Id : DBNull.Value },
                new object[] { "@purchase_date", DbType.Date, entity.TransactionDate },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblPurchase} (suppliers_id, purchase_date, created_by) VALUES (@suppliers_id, @purchase_date, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PurchasesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PurchasesModel> entityList)
        {
            throw new NotImplementedException();
        }
    }
}
