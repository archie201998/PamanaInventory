namespace ZenBiz.AppModules.Models
{
    internal class UsersModel
    {
        public int Id { get; set; }
        public RolesModel Roles { get; set; } = new();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
