namespace DiscountCalculator
{
    public class DiscountCalculator
    {
        public static string Get()
        {
            bool withDiscount = false;
            bool[] errors = new bool[3];

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            bool resultAge = uint.TryParse(Console.ReadLine(), out uint age);
            errors[0] = resultAge;

            Console.Write("Введите количество покупок: ");
            bool resultCount = uint.TryParse(Console.ReadLine(), out uint count);
            errors[1] = resultCount;

            Console.Write("Введите сумму потраченых денег: ");
            bool resultSpended = uint.TryParse(Console.ReadLine(), out uint spended);
            errors[2] = resultSpended;

            if (errors.Contains(false)) throw new Exception($"Одно из значений было введено неправильно!");

            if (age > 60) withDiscount = true;
            if (count >= 4) if (spended >= 5000) withDiscount = true;

            return withDiscount ? "Поздравляем, Вам доступна скидка!" : "Вам не доступна скидка";
        }
    }
}
