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
            throw new NotImplementedException();
        }

        public bool Delete(List<PurchasePaymentModel> entityList)
        {
            throw new NotImplementedException();
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
                new object[] { "@purchased_id", DbType.Int32, purchaseId },
            };

            string query = $"SELECT id, payment_types_id, amount, date_paid, ref_code, payment_type FROM {viewPurchasePayments} WHERe sales_id = @sales_id";
            return _dbGenericCommands.Fill(query, parameters);
        }
    }
}