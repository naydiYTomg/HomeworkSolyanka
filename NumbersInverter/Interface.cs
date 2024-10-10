using System.Text;

namespace NumbersInverter
{
    public class Interface
    {
        public static string Get()
        {
            Console.Write("Введите число: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (!result) throw new Exception("Вы ввели не число!");

            string temp = number.ToString();
            int numberOfChars = temp.Length;
            int charIndex = numberOfChars - 1;
            StringBuilder output = new StringBuilder();

            while (true)
            {
                if (charIndex < 0) break;
                output.Append(temp[charIndex]);
                charIndex--;
            }

            string finalResult = output.ToString();

            if (output.ToString()[0] == '0')
            {
                while(output.ToString()[0] == '0')
                {
                    output.Remove(0, 1);
                }
            }
            return output.ToString();
        }   
    }
}
