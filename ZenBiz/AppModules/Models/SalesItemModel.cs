namespace ZenBiz.AppModules.Models
{
    internal class SalesItemModel
    {
        public int Id { get; set; }
        public SalesModel Sales { get; set; } = new();
        public ItemsModel Items { get; set; } = new();
        public StoresModel Stores { get; set; } = new();
        public decimal UnitCost { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
