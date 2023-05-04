namespace ZenBiz.AppModules.Models
{
    internal class PaymentsModel
    {
        public int Id { get; set; }
        public SalesModel Sales { get; set; } = new();
        public PaymentTypesModel PaymentTypes { get; set; } = new();
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; }
        public string RefCode { get; set; } = string.Empty;
        public UsersModel Users { get; set; } = new();
    }
}
