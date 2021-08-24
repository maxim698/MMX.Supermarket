using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    interface IShoping:ISale
    {
        public  uint CountIsByu { get; set; }
        public decimal Price { get; set; }

        public string Name { get;  set; }

        public uint Count { get; set; }
    }
}
