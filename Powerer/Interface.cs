namespace Powerer
{
    public class Interface
    {

        public static double Get()
        {
            bool resultFirst = uint.TryParse(Console.ReadLine(), out uint number);
            bool resultSecond = uint.TryParse(Console.ReadLine(), out uint power);
            if (!resultFirst || !resultSecond) throw new Exception("");
            return Math.Pow(number, power);
            
        }
    }
}
