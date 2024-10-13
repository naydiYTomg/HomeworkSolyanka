namespace Powerer
{
    public class Powerer
    {

        public static double Get()
        {
            bool resultFirst = uint.TryParse(Console.ReadLine(), out uint number);
            bool resultSecond = uint.TryParse(Console.ReadLine(), out uint power);
            if (!resultFirst || !resultSecond) throw new Exception("");
            return Math.Pow(number, power);
            
        }
        public static double GetTest(uint number, uint power) { return Math.Pow(number, power); }
    }
}
