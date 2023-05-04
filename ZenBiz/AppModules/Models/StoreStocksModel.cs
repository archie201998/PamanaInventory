namespace ZenBiz.AppModules.Models
{
    internal class StoreStocksModel
    {
        public int Id { get; set; }
        public StoresModel Store { get; set; } = new();
        public StocksModel Stock { get; set; } = new();
    }
}
