using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSolyanka
{
    interface IDeliver
    {
        uint fixedPrice { get; set; }
        uint priceForKM { get; set; }
    }
}
