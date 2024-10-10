using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService
{
    class ExerciseDelivery(uint fixedPrice, uint priceForKM) : IDeliver
    {
        public uint fixedPrice { get; set; } = fixedPrice;
        public uint priceForKM { get; set; } = priceForKM;

        public uint CalculatePrice(uint length)
        {
            return fixedPrice + length * priceForKM;
        }
    }
}
