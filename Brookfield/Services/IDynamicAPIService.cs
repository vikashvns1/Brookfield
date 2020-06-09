using Brookfield.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Brookfield.Services
{
   public interface IDynamicAPIService
    {
        Task<string> GetAppConfiguration(string connection,string spName,string action);
        Task<string> InsertData(ExpandoObject obj, string connection, string spName, string action);
        Task<string> GetDatabyParam(List<Param> obj, string connection, string spName, string action);
    }
}
