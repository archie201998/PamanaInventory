namespace ZenBiz.AppModules.Models
{
    internal class SalesServicesModel
    {
        public int Id { get; set; }
        public SalesModel Sales { get; set; } = new();
        public ServicesModel Services { get; set; } = new();
        public PersonnelModel Personnel { get; set; } = new();
        public BranchModel Stores { get; set; } = new();
        public decimal Fee { get; set; }
    }
}
