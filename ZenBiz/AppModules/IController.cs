using System.Data;

namespace ZenBiz.AppModules
{
    internal interface IController<T> where T : class
    {
        bool IdExist(int id);
        DataTable Fetch();
        DataTable FetchBySearch(string searchText);
        Dictionary<string, string> FindById(int Id);
        int Count();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(List<T> entityList);
    }
}
