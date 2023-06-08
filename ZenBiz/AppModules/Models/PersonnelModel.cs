namespace ZenBiz.AppModules.Models
{
    internal class PersonnelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public UsersModel Users { get; set; } = new();
    }
}
