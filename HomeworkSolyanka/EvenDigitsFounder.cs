namespace EvenDigitsFounder
{
    public class EvenDigitsFounder
    {
        public static string Get()
        {
            Console.Write("Введите число: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (!result) throw new Exception("Вы ввели не число!");

            string temp = number.ToString();
            int count = 0;
            int i = 0;

            while (true) { 
                if (i >= temp.Length) break;
                //Console.WriteLine();
                if (int.Parse(temp[i].ToString()) % 2 == 0)
                {
                    //Почему-то если я пишу int.Parse(temp[i].ToString()) % 2 != 0 оно неправильно работает, так что вот так
                }
                else
                {
                    count++;
                }
                i++;
            }
            return $"В вашем числе {count} нечётных цифр";
        }
    }
}
