using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PaymentsController : IPayments
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPayments = "payments";
        private const string viewPayments = "view_payments";

        public PaymentsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PaymentsModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblPayments} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, sales_id, payment_types_id, amount, date_paid, ref_code, payment_type FROM {viewPayments}";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchbySalesId(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };

            string query = $"SELECT id, payment_types_id, amount, date_paid, ref_code, payment_type FROM {viewPayments} WHERe sales_id = @sales_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT sales_id, payment_types_id, payment_type, amount, date_paid, ref_code FROM {viewPayments} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PaymentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, entity.Sales.Id },
                new object[] { "@payment_types_id", DbType.Int32, entity.PaymentTypes.Id },
                new object[] { "@amount", DbType.Decimal, entity.Amount },
                new object[] { "@date_paid", DbType.Date, entity.DatePaid },
                new object[] { "@ref_code", DbType.String, entity.RefCode },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblPayments} (sales_id, payment_types_id, amount, date_paid, ref_code, created_by) VALUES (@sales_id, @payment_types_id, @amount, @date_paid, @ref_code, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PaymentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@payment_types_id", DbType.Int32, entity.PaymentTypes.Id },
                new object[] { "@amount", DbType.Decimal, entity.Amount },
                new object[] { "@date_paid", DbType.Date, entity.DatePaid },
                new object[] { "@ref_code", DbType.String, entity.RefCode },
                new object[] { "@updated_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblPayments} SET payment_types_id = @payment_types_id, amount = @amount, date_paid = @date_paid, ref_code = @ref_code, updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal SumTotalPaymentsPerSalesId(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };
            string query = $"SELECT SUM(amount) FROM {tblPayments} WHERE sales_id = @sales_id GROUP BY sales_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

        public decimal BalanceAmount(int salesId)
        {
            decimal servicesGross = Factory.SalesServicesController().GrossSales(salesId);
            decimal itemsGrossSales = Factory.SalesItemController().GrossSales(salesId);
            decimal totalSales = (servicesGross + itemsGrossSales) - SumTotalPaymentsPerSalesId(salesId);

            return totalSales;
        }

        public DataTable FetchByCustomerID(int customerID)
        {
            var parameters = new object[][]
                       {
                new object[] { "@customers_id", DbType.Int32, customerID },
                       };
            string query = $"SELECT id, trans_no, trans_date FROM {viewPayments} WHERE customers_id = @customers_id ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FetchbySalesId_Dict(int salesId)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32,  salesId },
            };

            string query = $"SELECT payment_types_id, payment_type, amount, date_paid, ref_code FROM {viewPayments} WHERE sales_id = @sales_id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }
    }
}
