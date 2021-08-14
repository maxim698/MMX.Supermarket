using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Buyer:Milk
    {
           
        public decimal Cash { get; set; }
        public void Buy(IShoping shoping)
        {
            shoping.Buy();
            Cash -= Price;
        }

        public void PrintCash()
        {
            Console.WriteLine($"Ваш баланс: {Cash}");
        }
    }
}
