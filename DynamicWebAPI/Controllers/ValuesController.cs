using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DAL.ExecuteSp exSp = new DAL.ExecuteSp();
        // GET: api/<ValuesController>
        [HttpGet("{connectionString},{StoreProcedureName},{CommondName}")]
        public async Task<IEnumerable<object>> Get(string connectionString, string StoreProcedureName, string CommondName)
        {
            return  await exSp.ExecuteSpGetData(connectionString, StoreProcedureName,CommondName);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("{connectionString},{StoreProcedureName},{CommondName}")]
        public async Task<IEnumerable<object>> Post([FromBody] ExpandoObject value, string connectionString, string StoreProcedureName, string CommondName)
        {
           return await exSp.ExecuteSpMasterData(connectionString,StoreProcedureName,CommondName,value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
