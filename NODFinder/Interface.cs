namespace NODFinder
{
    public class Interface
    {
        public static string Get()
        {
            bool[] results = new bool[2];

            Console.Write("Введите первое число: ");
            bool firstResult = int.TryParse(Console.ReadLine(), out int firstNum);
            results[0] = firstResult;

            Console.Write("Введите второе число: ");
            bool secondResult = int.TryParse(Console.ReadLine(), out int secondNum);
            results[1] = secondResult;

            if (results.Contains(false)) throw new Exception("Cheto nepravilno vveli");

            int numA = firstNum;
            int numB = secondNum;

            int finalResult;

            while (true)
            {
                int ostatok = numA > numB ? numA % numB : numB % numA;
                if (ostatok == 0) { finalResult = numA > numB ? numB : numA; break; }
                numA = numB;
                numB = ostatok;
            }
            return ($"НОД({firstNum}, {secondNum}) = {finalResult}");
        }
        public static int GetRaw()
        {
            bool[] results = new bool[2];

            Console.Write("Введите первое число: ");
            bool firstResult = int.TryParse(Console.ReadLine(), out int firstNum);
            results[0] = firstResult;

            Console.Write("Введите второе число: ");
            bool secondResult = int.TryParse(Console.ReadLine(), out int secondNum);
            results[1] = secondResult;

            if (results.Contains(false)) throw new Exception("Cheto nepravilno vveli");

            int numA = firstNum;
            int numB = secondNum;

            int finalResult;

            while (true)
            {
                int ostatok = numA > numB ? numA % numB : numB % numA;
                if (ostatok == 0) { finalResult = numA > numB ? numB : numA; break; }
                numA = numB;
                numB = ostatok;
            }
            return finalResult;
        }
    }
}
