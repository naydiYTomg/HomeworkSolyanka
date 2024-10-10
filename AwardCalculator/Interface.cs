using System.Globalization;

namespace AwardCalculator
{
    public class Interface
    {
        public static string Get()
        {
            CultureInfo culture = CultureInfo.InstalledUICulture;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string znak = culture.Name == "ru-RU" ? "\u20BD" : "$";
            //Console.WriteLine(znak);
            Console.Write("Введите план продаж: ");
            bool result = uint.TryParse(Console.ReadLine(), out uint soldPlan);
            if (!result) throw new Exception("Вы ввели неверное число или не число вовсе");
            Console.Write("Введите сумму продаж за этот месяц: ");
            result = int.TryParse(Console.ReadLine(), out int monthSolds);
            if (!result) throw new Exception("Вы ввели неверное число или не число вовсе");
            if (monthSolds < soldPlan) { return "Премия не начисляется, продажи меньше плана"; }
            else { double premiya = ((monthSolds - soldPlan) / 100) * 10; return $"Ваша премия - {premiya}{znak}"; }
        }
    }
}
