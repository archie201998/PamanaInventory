namespace ZenBiz.AppModules.Models
{
    internal class BranchStocksModel
    {
        public int Id { get; set; }
        public BranchModel Store { get; set; } = new();
        public StocksModel Stock { get; set; } = new();
    }
}
