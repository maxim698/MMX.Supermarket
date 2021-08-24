using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    class MyExcention : Exception
    {
        public MyExcention():base("Ошибка!Не правильный ввод данных")
        {
        }

        
    }
}
