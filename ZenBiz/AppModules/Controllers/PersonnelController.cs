using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PersonnelController : IPersonnel
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPersonnel = "personnel";

        public PersonnelController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PersonnelModel> entityList)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
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

        public bool Insert(PersonnelModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(PersonnelModel entity)
        {
            throw new NotImplementedException();
        }
    }
}