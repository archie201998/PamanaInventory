namespace ZenBiz.AppModules.Models
{
    internal class BranchStocksModel
    {
        public int Id { get; set; }
        public BranchModel Branch { get; set; } = new();
        public StocksModel Stock { get; set; } = new();
    }
}
