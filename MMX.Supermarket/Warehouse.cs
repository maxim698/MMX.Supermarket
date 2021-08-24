using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class Warehouse :Products, IWarehouse
    {
        public override uint Count { get ; set ; }
        public override uint CountIsByu { get ; set ; }
        public override string Name { get ; set ; }
        public override int Energy { get ; set ; }
        public override decimal Price { get ; set ; }

        public override double Weight =>200 ;

        public override DayOfWeek DayOfWeek { get ; set ; }

        public  void PrintInfo<T>(T products)
            where T:IShoping
        {
            Console.WriteLine($"Имя товара\t :{products.Name}\n" +
                              $"Количество товара\t :{products.Count}\n" +
                              $"Цена товара\t :{products.Price}\n");
        }
    }
}
