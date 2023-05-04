using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class BusinessDetailsController : IBusinessDetails
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblBusinessDetails = "business_details";

        public BusinessDetailsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<BusinessDetailsModel> entityList)
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
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT name, address, permit_no, tin FROM {tblBusinessDetails} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BusinessDetailsModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(BusinessDetailsModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
