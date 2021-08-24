﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
   abstract class Products:IShoping
    {
        public Products()
        {

        }
        
        public abstract uint Count { get; set; }
        public abstract uint CountIsByu { get; set; }
        public abstract string Name { get; set; }
        public abstract int Energy { get; set; }
        public abstract decimal Price { get; set; }
        public abstract double Weight { get; }
        public abstract DayOfWeek DayOfWeek { get; set; }
        
    }
}
