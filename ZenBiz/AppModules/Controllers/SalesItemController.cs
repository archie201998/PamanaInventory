using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class SalesItemController : ISalesItem
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblSalesItem = "sales_item";
        private const string viewSalesItem = "view_sales_item";

        public SalesItemController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<SalesItemModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblSalesItem} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public bool DeletePerSalesId(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };

            string query = $"DELETE FROM {tblSalesItem} WHERE sales_id = @sales_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, sales_id, trans_no, trans_date, customers_id, customer_name, stores_id, store_name, items_id, sku_code, item_name, unit_name, sold_unit_cost, sold_price, sold_quantity,(sold_price * sold_quantity) AS total_sale FROM {viewSalesItem} ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query);
        }

        string salesItemColumns = "id, sales_id, trans_no, trans_date, customers_id, customer_name, stores_id, store_name, items_id, sku_code, item_name, unit_name, sold_unit_cost, sold_price, sold_quantity,(sold_price * sold_quantity) AS gross_sale";

        public DataTable Fetch(DateTime dateFrom, DateTime dateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
            };

            string query = $"SELECT {salesItemColumns} FROM {viewSalesItem} WHERE trans_date BETWEEN @date_from AND @date_to ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(DateTime dateFrom, DateTime dateTo, int storeId)
        {
            var parameters = new object[][]
            {
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
                new object[] { "@stores_id", DbType.Int32, storeId },
            };

            string query = $"SELECT {salesItemColumns} FROM {viewSalesItem} WHERE stores_id = @stores_id AND (trans_date BETWEEN @date_from AND @date_to) ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }


        string soldItemsColumns = "id, sales_id, trans_no, trans_date, customers_id, customer_name, stores_id, store_name, items_id, sku_code, item_name, category_name, unit_name, sold_unit_cost, sold_price, SUM(sold_quantity) AS sold_quantity, (sold_price * SUM(sold_quantity)) AS gross_sale";

        public DataTable FetchSoldItems(DateTime dateFrom, DateTime dateTo, int storeId)
        {
            var parameters = new object[][]
            {
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
                new object[] { "@stores_id", DbType.Int32, storeId },
            };
            string querySoldItems = $"SELECT {soldItemsColumns} FROM {viewSalesItem} WHERE stores_id = @stores_id AND (trans_date BETWEEN @date_from AND @date_to) GROUP BY items_id, sold_price";
            return _dbGenericCommands.Fill(querySoldItems, parameters);
        }

        public DataTable FetchSoldItems(DateTime dateFrom, DateTime dateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
            };
            string querySoldItems = $"SELECT {soldItemsColumns} FROM {viewSalesItem} WHERE (trans_date BETWEEN @date_from AND @date_to) GROUP BY items_id, sold_price";
            return _dbGenericCommands.Fill(querySoldItems, parameters);
        }

        public DataTable FetchBySalesId(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };
            string query = $"SELECT id, items_id, stores_id, store_name, item_name, unit_name, sold_unit_cost, sold_price, sold_quantity, (sold_price * sold_quantity) AS total_sale FROM {viewSalesItem} WHERE sales_id = @sales_id ORDER BY item_name";
            return _dbGenericCommands.Fill(query, parameters);
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

        public bool Insert(SalesItemModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, entity.Sales.Id },
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@stores_id", DbType.Int32, entity.Stores.Id },
                new object[] { "@unit_cost", DbType.Decimal, entity.UnitCost},
                new object[] { "@price", DbType.Decimal, entity.Price},
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
            };

            string query = $"INSERT INTO {tblSalesItem} (sales_id, items_id, stores_id, unit_cost, price, quantity) VALUES (@sales_id, @items_id, @stores_id, @unit_cost, @price, @quantity)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(SalesItemModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@sales_id", DbType.Int32, entity.Sales.Id },
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@stores_id", DbType.Int32, entity.Stores.Id },
                new object[] { "@unit_cost", DbType.Decimal, entity.UnitCost},
                new object[] { "@price", DbType.Decimal, entity.Price},
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
            };

            string query = $"UPDATE {tblSalesItem} SET sales_id = @sales_id, items_id = @items_id, stores_id = @stores_id, unit_cost = @unit_cost, price = @price, quantity = @quantity WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal GrossSales(int salesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@sales_id", DbType.Int32, salesId },
            };
            string query = $"SELECT SUM(price * quantity) FROM {tblSalesItem} WHERE sales_id = @sales_id GROUP BY sales_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

        public decimal GrossSales(DateTime dateFrom, DateTime dateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
            };
            string query = $"SELECT SUM(sold_price * sold_quantity) FROM {viewSalesItem} WHERE trans_date BETWEEN @date_from AND @date_to";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

        public decimal SumTotalStocksSold(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storeId },
                new object[] { "@items_id", DbType.Int32, itemId },
            };

            string query = $"SELECT SUM(quantity) FROM {tblSalesItem} WHERE stores_id = @stores_id AND items_id = @items_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }
    }
}
