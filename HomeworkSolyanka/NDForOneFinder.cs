namespace NDForOneFinder
{
    public class NDForOneFinder
    {
        public static string Get()
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int number)) throw new Exception("Вы ввели не число!");
            for (int i = number - 1;  i > 0; i--)
            {
                if (number % i == 0) return $"НД({number}) = {i}";
            }
            return $"хз почему";
        }
        public static int GetTest(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                if (number % i == 0) return i;
            }
            return -1;
        }
    }
}
