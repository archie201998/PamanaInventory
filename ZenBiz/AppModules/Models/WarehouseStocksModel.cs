namespace ZenBiz.AppModules.Models
{
    internal class WarehouseStocksModel
    {
        public int Id { get; set; }
        public WarehousesModel Warehouse { get; set; } = new();
        public StocksModel Stock { get; set; } = new();
    }
}
