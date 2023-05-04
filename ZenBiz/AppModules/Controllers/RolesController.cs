using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class RolesController : IRoles
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblRoles = "roles";

        public RolesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }


        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<RolesModel> entityList)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name FROM {tblRoles} WHERE name != 'SysAdmin'";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RolesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(RolesModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
