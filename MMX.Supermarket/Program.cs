using System;

namespace MMX.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var buyer = new Buyer(1000.0m);
            var milk = new Milk();
            var shampoo = new Shampoo();
            var ware = new Warehouse();

            buyer.Buy(milk, 3);
            buyer.Buy(shampoo, 3);
            buyer.PrintCash();
            ware.PrintInfo(milk);
            ware.PrintInfo(shampoo);
            

           
            
            
        }
    }
}
