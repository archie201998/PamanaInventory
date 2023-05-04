namespace ZenBiz.AppModules.Models
{
    internal class BusinessDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PermitNo { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;
    }
}
