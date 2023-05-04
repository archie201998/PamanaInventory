
namespace ZenBiz.AppModules.Models
{
    internal class CustomersModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactInfo { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public UsersModel Users { get; set; } = new();
    }
}
