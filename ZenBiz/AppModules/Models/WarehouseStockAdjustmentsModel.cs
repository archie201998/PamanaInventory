namespace ZenBiz.AppModules.Models
{
    internal class WarehouseStockAdjustmentsModel
    {
        public int Id { get; set; }
        public ItemsModel Items { get; set; } = new();
        public WarehousesModel Warehouses { get; set; } = new();
        public decimal Quantity { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime DateAdjusted { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
