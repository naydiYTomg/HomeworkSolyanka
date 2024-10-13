namespace PositiveNumsWhSqLsThanGiven
{
    public class PositiveNumberWhoseSquareLessThanGiven
    {
        public static int Get()
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int number)) throw new Exception("Вы ввели не число!");
            int count = 0;
            for (int i = 1; i < 100000; i++)
            {
                if (i * i < number && i * i != number) { count++; continue; }
                break;
            }
            return count;
        }
        public static int GetTest(int number)
        {
            int count = 0;
            for (int i = 0; i < 100000; i++)
            {
                if (i * i < number && i * i != number) { count++; continue; }
                break;
            }
            return count;
        }
    }
}
