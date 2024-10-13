using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService
{
    public class CourierService
    {
        public static uint Get()
        {
            ExerciseDelivery delivery = new(150, 70);
            Console.Write("Введите километраж: ");
            uint length;
            try
            {
                length = uint.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Вы ввели не число!");
            }
            return delivery.CalculatePrice(length);
        }
        public static uint GetTest(uint length, uint fixedPrice, uint priceForKM)
        {
            ExerciseDelivery delivery = new(fixedPrice, priceForKM); 
            return delivery.CalculatePrice(length);

            
        }
        //Console.WriteLine()
    }
}
