
namespace CourierService
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Добро пожаловать, выберите опцию: \n(1) Курьерская доставка\n(2) Калькулятор премии \n(3) Калькулятор вклада\n" +
                "(4) Калькулятор цены товара\n(5) Бронирование столика\n(6) Калькулятор скидки\n(7) Доставка грузов\n" +
                "(8) Возведение числа в степень\n(9) Искатор НОД 2 чисел\n(10) Искатор нечетных цифр данного числа\n(11) Инвертер числа\n(иное значение) Выход");
            bool result = uint.TryParse(Console.ReadLine(), out uint command);
            if (!result) { Environment.Exit(0); }
            switch (command)
            {
                
                case 1: Console.WriteLine(Interface.Get());
            }
        }
    }
}


