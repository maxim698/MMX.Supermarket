using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Shampoo : HouseholdChemicals, IShoping, ISale
    {
        public Shampoo()
        {
        }
        public override uint Count { get; set; } = 100;

        public override string Name { get; set; }="Shauma";
        public override decimal Price { get; set; } = 100;


        public override double Weight => 0.1;

        public override uint CountIsByu { get ; set ; }
        public override DayOfWeek DayOfWeek { get; set; } = DayOfWeek.Monday;
    }
}

