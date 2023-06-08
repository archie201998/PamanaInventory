using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class SalesServicesController : ISalesServices
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblSalesServices = "sales_services";

        public SalesServicesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public bool IdExist(int id)
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

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Insert(SalesServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(SalesServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<SalesServicesModel> entityList)
        {
            throw new NotImplementedException();
        }
    }

}