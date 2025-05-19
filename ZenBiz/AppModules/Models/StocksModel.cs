namespace ZenBiz.AppModules.Models
{
    internal class StocksModel
    {
        public int Id { get; set; }
        public ItemsModel Item { get; set; } = new();
        public SupplierModel Supplier { get; set; } = new();
        public decimal Quantity { get; set; }
        public DateTime? StockDate { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public DateTime? RepairedDate { get; set; }
        public string? User { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }

    }
}
