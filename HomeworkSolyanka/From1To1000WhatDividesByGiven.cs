namespace Fr1t1000
{
    public class From1To1000WhatDividesByGiven
    {
        public static int[] Get()
        {
            List<int> toReturn = new List<int>();
            Console.Write("Введите число: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (!result) throw new Exception("Вы ввели не число!");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    toReturn.Add(i);
                }
            }
            return toReturn.ToArray();
        }
        public static int[] GetTest(int number)
        {
            List<int> toReturn = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    //Console.WriteLine(i);
                    toReturn.Add(i);
                }
            }
            Console.WriteLine(toReturn.ToArray());
            return toReturn.ToArray();

        }
    }
}
