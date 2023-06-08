using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISalesServices : IController<SalesServicesModel>
    {
        DataTable FetchBySalesId(int salesId);
    }
}
