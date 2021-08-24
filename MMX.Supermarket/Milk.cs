using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Milk : Products, IShoping, ISale
    {
        public Milk()
        {
        }

        public override int Energy { get; set; } = 90;

        public override decimal Price { get; set; } =50.00m;

        public override double Weight => 1.0;

        public override uint Count { get; set; } = 100;
        public override string Name { get; set; } = "Простаквашино";
        public override DayOfWeek DayOfWeek { get; set; } = DayOfWeek.Thursday;
        public override uint CountIsByu { get ; set; }
    }
}
