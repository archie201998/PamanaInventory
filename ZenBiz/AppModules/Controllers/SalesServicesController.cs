using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class SalesServicesController : ISalesServices
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblSalesServices = "sales_services";
        private const string viewSalesServices = "view_sales_services";

        public SalesServicesController(IDbGenericCommands dbGenericCommands)
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

        public bool Insert(SalesServicesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, entity.Sales.Id },
                new object[] { "@services_id", DbType.Int32, entity.Services.Id },
                new object[] { "@personnel_id", DbType.Int32, entity.Personnel.Id },
                new object[] { "@fee", DbType.Decimal, entity.Fee },
            };

            string query = $"INSERT INTO {tblSalesServices} (sales_id, services_id, personnel_id, fee) VALUES (@sales_id, @services_id, @personnel_id, @fee)";

            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(SalesServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<SalesServicesModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblSalesServices} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable FetchBySalesId(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };
            string query = $"SELECT id, sales_id, services_id, personnel_id, services_name, personnel_name, fee FROM {viewSalesServices} WHERE sales_id = @sales_id ORDER BY services_name";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public bool DeletePerSalesId(int salesId)
        {
            var parameters = new object[][]
            {
               new object[] { "@sales_id", DbType.Int32, salesId },
            };

            string query = $"DELETE FROM {tblSalesServices} WHERE sales_id = @sales_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal GrossSales(int salesId)
        {
            var parameters = new object[][]
              {
                new object[] { "@sales_id", DbType.Int32, salesId },
              };
            string query = $"SELECT SUM(fee) FROM {viewSalesServices} WHERE sales_id = @sales_id GROUP BY sales_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }
    }

}