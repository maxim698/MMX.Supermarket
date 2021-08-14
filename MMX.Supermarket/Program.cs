using System;

namespace MMX.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var Buyer1 = new Buyer { Cash = 150.00m };
            Buyer1.Buy(new Milk());
            Buyer1.Buy(new Shampoo());
            Buyer1.PrintCash();

        }
    }
}
