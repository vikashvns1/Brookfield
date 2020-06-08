using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicWebAPI.Model
{
    public class StoredProcedureParameter
    {
        public string Name { get; set; }
        public string ParamType { get; set; }
        public string Value { get; set; }
    }
}
