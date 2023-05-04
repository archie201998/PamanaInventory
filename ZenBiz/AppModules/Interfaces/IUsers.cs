using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IUsers : IController<UsersModel>
    {
        bool UpdateWithoutPassword(UsersModel entity);
        bool UsernameExist(string username);
        int? Authenticate(string username, string password);
        bool CheckCurrentPassword(int userId, string password);
        bool ChangePassword(int userId, string password);
    }
}
