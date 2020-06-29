using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brookfield.Models
{
    public class Column
    {
        public string Name { get; set; }
        public bool Edit { get; set; }
        public bool Filter { get; set; }
        public bool IsPrimaryKey { get; set; } = false;
    }
}
