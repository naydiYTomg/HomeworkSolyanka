﻿
namespace HomeworkSolyanka
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
                
                case 1: Console.WriteLine(CourierService.CourierService.Get()); break;
                case 2: Console.WriteLine(AwardCalculator.AwardCalculator.Get()); break;
                case 3: Console.WriteLine(DepositCalculator.DepositCalculator.Get()); break;
                case 4: Console.WriteLine(ProductPriceCalculator.ProductPriceCalculator.Get()); break;
                case 5: Console.WriteLine(TableReservation.TableReservation.Get()); break;
                case 6: Console.WriteLine(DiscountCalculator.DiscountCalculator.Get()); break;
                case 7: Console.WriteLine(LightweightDelivery.LightweightDelivery.Get()); break;
                case 8: Console.WriteLine(Powerer.Powerer.Get()); break;
                case 9: Console.WriteLine(NODFinder.NODFinder.Get()); break;
                case 10: Console.WriteLine(EvenDigitsFounder.EvenDigitsFounder.Get()); break;
                case 11: Console.WriteLine(NumbersInverter.NumbersInverter.Get()); break;
            }
        }
    }
}


