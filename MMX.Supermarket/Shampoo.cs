using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Shampoo : HouseholdChemicals,ISale
    {
        public override int Count { get; set; } = 100;

        public override string Name => "Shauma";
        public override decimal Price => 140.00m;

        public override double Weight => 0.1;

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
            if (IsDayOfWeek(DateTime.Now, DayOfWeek.Saturday))
            {
                return Price / 2;
            }
            return Price;
        }
    }
}

