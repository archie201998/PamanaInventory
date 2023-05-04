namespace ZenBiz.AppModules.Models
{
    internal class SalesModel
    {
        public int Id { get; set; }
        public CustomersModel Customers { get; set; } = new();
        public string TransactioNo { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
