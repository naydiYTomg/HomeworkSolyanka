using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepositCalculator
{
    public class DepositCalculator
    {
        public static string Get()
        {
            
            Console.Write("Введите сумму вклада: ");
            bool result = uint.TryParse(Console.ReadLine(), out uint vklad);
            if (!result) throw new Exception("Вы ввели не верное число или не число вовсе!");
            uint pribil = ((vklad / 100) * 10) + (((vklad / 10) * 10) / 2);
            return $"Ваша прибыль со вклада: {pribil}";
        }
        public static uint GetTest(uint vklad)
        {
            uint pribil = ((vklad / 100) * 10) + (((vklad / 10) * 10) / 2);
            return pribil;
        }
    }
}
