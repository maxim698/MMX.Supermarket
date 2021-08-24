using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    interface IWarehouse
    {
        public void PrintInfo<T>(T products) where T : IShoping;
        
    }
}
