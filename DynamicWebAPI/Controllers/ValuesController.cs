using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DynamicWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DAL.ExecuteSp exSp = new DAL.ExecuteSp();
        // GET: api/<ValuesController>
        [HttpGet("{connectionString},{StoreProcedureName},{CommondName},{ProviderName}")]
        public async Task<IEnumerable<object>> Get(string connectionString, string StoreProcedureName, string CommondName, string ProviderName)
        {
            return  await exSp.ExecuteSpGetData1(connectionString, StoreProcedureName,CommondName,ProviderName);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/<ValuesController>
        [HttpPost("{CommondName},{connectionString},{StoreProcedureName},{ProviderName}")]
        public async Task<OutputData> Post(string CommondName, string connectionString, string StoreProcedureName, string ProviderName, [FromBody] ExpandoObject value)
        {
           return await exSp.ExecuteSpMasterData1(connectionString,StoreProcedureName,CommondName,ProviderName, value);
        }

        [HttpPost("{connectionString},{StoreProcedureName},{ProviderName}")]
        public async Task<OutputData> GetDatabyParam([FromBody] List<Param> value, string connectionString, string StoreProcedureName,string ProviderName)
        {           
            var reponse= await exSp.GetDataSpMasterByParam1(connectionString, StoreProcedureName,"Select", ProviderName, value);
            return reponse;
        }        
    }
}
