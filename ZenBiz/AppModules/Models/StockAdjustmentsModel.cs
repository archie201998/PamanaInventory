namespace ZenBiz.AppModules.Models
{
    internal class StockAdjustmentsModel
    {
        public int Id { get; set; }
        public ItemsModel Items { get; set; } = new();
        public decimal Quantity { get; set; }
        public string Reason { get; set; } = string.Empty;
        // add or minus string value only
        public string AdjustmentType { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
