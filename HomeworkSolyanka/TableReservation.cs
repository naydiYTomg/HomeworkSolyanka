namespace TableReservation
{
    public class TableReservation
    {
        public static string Get()
        {
            Console.Write("Введите количество человек: ");
            bool result = uint.TryParse(Console.ReadLine(), out uint count);
            if (!result || count > 8) throw new Exception("Вы ввели неверное количество людей! (меньше нуля или больше 8)"); 
            return rentATable(count);
        }
        static string rentATable(uint count)
        {
            if (count <= 2)
            {
                return "Вам подходит маленький стол. Забронировали для вас";
                //string answer = Console.ReadLine().ToLower();
                //if (answer == "нет") return;
                //else if (answer == "да")
                //{
                //    Random random = new Random();
                //    makeRent(count, new TimeOnly(random.Next(24), 0), (uint)random.Next());        
                //}
                //else throw new Exception("Вы ввели неверное значени!");
                
            }else if (count <= 4)
            {
                return "Вам подходит средний стол. Забронировали для вас";
            }
            else if (count <= 8)
            {
                return "Вам подходит большой стол. Забронировали для вас"; ;
            }
            return "чё-то не так хз";
        }

        static void makeRent(uint count, TimeOnly time, uint tableNumber)
        {
            throw new NotImplementedException("<TODO>::Renting function");
        }
        public static int GetTest(uint count)
        {
            if (count <= 2) return 1;
            else if (count <= 4) return 2;
            else if (count <= 8) return 3;
            else return 0;
        }
    }
}
