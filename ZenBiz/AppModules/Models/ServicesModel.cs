namespace ZenBiz.AppModules.Models
{
    internal class ServicesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
