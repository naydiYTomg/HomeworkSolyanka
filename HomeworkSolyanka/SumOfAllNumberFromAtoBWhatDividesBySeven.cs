namespace SumOfAllNumberFromAtoBWhatDividesBySeven
{
    public class SumOfAllNumberFromAtoBWhatDividesBySeven
    {
        public static int Get()
        {
            Console.Write("Введите число А: ");
            if (!int.TryParse(Console.ReadLine(), out int firstNumber)) throw new Exception("Вы ввели не число!");
            Console.Write("Введите число В: ");
            if (!int.TryParse(Console.ReadLine(), out int secondNumber)) throw new Exception("Вы ввели не число!");
            var range = (firstNumber > secondNumber) ? Enumerable.Range(secondNumber, firstNumber) : Enumerable.Range(firstNumber, secondNumber);
            int returnSum = 0;
            foreach (int num in range)
            {
                if (num % 7 == 0) returnSum += num;
            }
            return returnSum;
        }
        public static int GetTest(int firstNumber, int secondNumber)
        {
            var range = (firstNumber > secondNumber) ? Enumerable.Range(secondNumber, firstNumber - secondNumber + 1) : Enumerable.Range(firstNumber, secondNumber - firstNumber + 1);
            int returnSum = 0;

            //var str = string.Join(", ", range.ToArray());
            //Console.WriteLine(str);
            foreach (int num in range.ToArray())
            {
                //Console.WriteLine(num);
                if (num % 7 == 0) { returnSum += num; }
            }
            return returnSum;
        }
    }
}
