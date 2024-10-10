namespace LightweightDelivery
{
    public class Interface
    {
        public static string Get()
        {
            bool[] errors = new bool[5];

            Console.Write("Введите длину посылки: ");
            bool resultLength = uint.TryParse(Console.ReadLine(), out uint length);
            errors[0] = resultLength;

            Console.Write("Введите ширину посылки: ");
            bool resultWidth = uint.TryParse(Console.ReadLine(), out uint width);
            errors[1] = resultWidth;

            Console.Write("Введите высоту посылки: ");
            bool resultHeight = uint.TryParse(Console.ReadLine(), out uint height);
            errors[2] = resultHeight;

            Console.Write("Введите массу посылки: ");
            bool resultMass = uint.TryParse(Console.ReadLine(), out uint mass);
            errors[3] = resultMass;

            Console.Write("Введите расстояние: ");
            bool resultDistance = uint.TryParse(Console.ReadLine(), out uint distance);
            errors[4] = resultDistance;

            if (errors.Contains(false)) throw new Exception($"Одно из значений было введено неправильно!");

            uint sumOfValues = length + height + width;

            if (length > 100 || width > 100 || height > 100) { return ("Ваша посылка не малогабаритна! Ни одно из измерений не должно превышать 100см!"); }
            if (sumOfValues > 150) { return ("Ваша посылка не малогабаритна! Сумма длины, ширины и высоты не должны превышать 150см!"); }
            if (mass > 10) { return ("Ваша посылка не малогабаритна! Масса посылки не должна превышать 10кг!"); }
            if (!Enumerable.Range(3, 10).Contains((int) distance)) { return ("Расстояние не находится в диапазоне от 3 до 10км!"); }
            return ("Успешно! Ваша посылка малогабаритна!");
        }
    }
}
