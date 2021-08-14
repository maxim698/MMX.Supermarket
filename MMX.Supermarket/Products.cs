using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
   abstract class Products:IShoping
    {
        public abstract int Count { get; set; }
        public abstract string Name { get; }
        public abstract int Energy { get; }
        public abstract decimal Price { get; }
        public abstract double Weight { get; }

        public abstract void Buy();
      

        public abstract decimal Sale();
        
        

    }
}
