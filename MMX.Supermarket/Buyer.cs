using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Buyer
    {
        public decimal Cash { get; set; }
        public Buyer(decimal cash)
        {
            if (cash>0)
            {
                Cash = cash;
            }
            else
            {
                try
                {
                    throw new MyExcention();
                }
                catch (MyExcention ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Работа приложения завершена!");
                    Environment.Exit(0);
                }
            }
        }
        public List<string> listProducts = new List<string>();
        public void AddingShoppingCart(IShoping shoping)
        {
            listProducts.Add(shoping.Name);
            Console.WriteLine($"Ваш товар добавлен в корзину {shoping.GetType().Name} : {shoping.Name}");
        }//метод добавления в корзину
        public void PrintListProducts()
        {
            Console.WriteLine("Ваш список продуктов : ");
            foreach (var item in listProducts)
            {
                Console.WriteLine(item);
            }
        }//список продуктов добавленных в корзину

        public void AddCountBuying<T>(T products)
            where T : IShoping
        {
            products.CountIsByu++;
        }//метод для инкремента количества покупок
        public void Buy<T>( T products,uint buyCount)
           where T : IShoping
        {
            if (buyCount > 0)
            {
                products.CountIsByu = buyCount;
            }
            else
            {
                try
                {
                    throw new MyExcention();
                }
                catch (MyExcention) when (buyCount <= 0)
                {
                    Console.WriteLine("Количество для покупки не может быть равняться нулю или быть отрицательным");
                }
                finally
                {
                    Console.WriteLine("Работа приложения завершена!");
                    Environment.Exit(0);
                }
            }
            
            if (Cash > 0 && products.Price <= Cash)
            {
                if (DateTime.Now.DayOfWeek == products.DayOfWeek)
                {
                    products.Price = products.Price / 2;
                }
                Cash -= products.Price*products.CountIsByu;
                if (Cash<0)
                {
                    Console.WriteLine("Недостаточно средств!Пополните баланс!");
                }
                products.Count -= products.CountIsByu;
            }
            
        }//метод для покупки

        public void PrintCountWareHouse<T>( T products)
            where T : IShoping
        {
            Console.WriteLine($"{products.Name} осталось на складе :{ products.Count}" ); 
        }
        
        public void PrintCash()
        {
            Console.WriteLine($"Ваш баланс: {Cash}");
        }//метод для вывода оставшихся денег

        
    }
}
