using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Milk:Products,ISale
    {

        public override string Name => "Простаквашино";

        public override int Energy => 20;

        public override decimal Price => 50.00m;

        public override double Weight => 1.0;

        public override int Count { get; set; } = 100;

        public override void Buy()
        {
            Console.WriteLine("Товар перенесен в корзину");
            Count--;  
        }
        public bool IsDayOfWeek(DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
        public override decimal Sale()
        {
            if (IsDayOfWeek(DateTime.Now,DayOfWeek.Saturday))
            {
                return Price / 2;
            }
            return Price;
        }
    }
}
