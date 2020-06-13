using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicWebAPI.Model
{
    public class OutputData
    {
        public List<ExpandoObject> DynamicData { get; set; }        
        public string Msg { get; set; }
        public int ReturnsValue { get; set; }
    }
}
