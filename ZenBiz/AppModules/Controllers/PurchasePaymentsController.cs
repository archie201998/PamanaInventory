using System.Data;
using System.Transactions;
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
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT purchases_id, payment_types_id, amount, date_paid, ref_no FROM {tblPurchasePayments} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Insert(PurchasePaymentModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, entity.Purchase.Id },
                new object[] { "@payment_types_id", DbType.Int32, entity.PaymentTypes.Id },
                new object[] { "@amount", DbType.Decimal, entity.Amount },
                new object[] { "@date_paid", DbType.Date, entity.DatePaid },
                new object[] { "@ref_no", DbType.String, entity.RefCode },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblPurchasePayments} (purchases_id, payment_types_id, amount, date_paid, ref_no, created_by) VALUES (@purchases_id, @payment_types_id, @amount, @date_paid, @ref_no, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PurchasePaymentModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@payment_types_id", DbType.Int32, entity.PaymentTypes.Id },
                new object[] { "@amount", DbType.Decimal, entity.Amount },
                new object[] { "@date_paid", DbType.Date, entity.DatePaid },
                new object[] { "@ref_no", DbType.String, entity.RefCode },
                new object[] { "@updated_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblPurchasePayments} SET payment_types_id = @payment_types_id, amount = @amount, date_paid = @date_paid, ref_no = @ref_no, updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Delete(List<PurchasePaymentModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblPurchasePayments} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        } 

        public decimal TotalAmountPaidPerPurchased(int purchaseId)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, purchaseId },
            };
            string query = $"SELECT SUM(amount) FROM {tblPurchasePayments} WHERE purchases_id = @purchases_id GROUP BY purchases_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

        public decimal BalanceAmountPerPurchased(int purchaseId)
        {
            decimal totalAmountPurchased = Factory.PurchaseItemController().TotalAmountPerPurchased(purchaseId);
            decimal totalAmountPayed = TotalAmountPaidPerPurchased(purchaseId);

            return totalAmountPurchased - totalAmountPayed;
        }

        public DataTable FetchbyPurchaseId(int purchaseId)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, purchaseId },
            };

            string query = $"SELECT id, payment_types_id, amount, date_paid, ref_no FROM {tblPurchasePayments} WHERE purchases_id = @purchases_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBySupplierID(int supplierId)
        {
            var parameters = new object[][]
            {
                new object[] { "@suppliers_id", DbType.Int32, supplierId },
            };

            string query = $"SELECT * FROM {viewPurchasePayments} WHERE suppliers_id = @suppliers_id";
            return _dbGenericCommands.Fill(query, parameters);
        }
    }
}