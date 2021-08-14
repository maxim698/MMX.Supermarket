using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMX.Supermarket
{
    interface ISale
    {
        bool IsDayOfWeek(DateTime dateTime, DayOfWeek dayOfWeek);
    }
}
