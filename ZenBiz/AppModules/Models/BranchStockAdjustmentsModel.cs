namespace ZenBiz.AppModules.Models
{
    internal class BranchStockAdjustmentsModel
    {
        public int Id { get; set; }
        public ItemsModel Items { get; set; } = new();
        public BranchModel Stores { get; set; } = new();
        public decimal Quantity { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime DateAdjusted { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
