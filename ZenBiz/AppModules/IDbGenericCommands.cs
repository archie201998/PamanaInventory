using System.Data;

namespace ZenBiz.AppModules
{
    internal interface IDbGenericCommands
    {
        DataTable Fill(string query);
        DataTable Fill(string query, params object[][] parameters);
        bool ExecuteNonQuery(string query, params object[][] parameters);
        DataTable ExecuteReader(string query, params object[][] parameters);
        string ExecuteScalar(string query, params object[][] parameters);
        string ExecuteScalar(string query);
    }
}
