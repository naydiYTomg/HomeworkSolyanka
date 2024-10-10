namespace ProductPriceCalculator
{
    public class ProductPriceCalculator
    {
        
        struct Receipt
        {
            public string name;
            public double pricePerUnit;
            public uint count;
            public bool inStock;
            public uint discount;

            public Receipt(string name, double pricePerUnit, uint count, bool inStock, uint discount)
            {
                this.name = name;
                this.pricePerUnit = pricePerUnit;
                this.count = count;
                this.inStock = inStock;
                this.discount = discount;
            }

            public double Calc()
            {
                double result = (pricePerUnit * count) - ((pricePerUnit * count) * (discount / 100d));
                //Console.WriteLine(pricePerUnit * count * (discount / 100d));
                return result;
            }
            public override string ToString()
            {
                return $"Receipt with name: {name},\nprice per unit: {pricePerUnit}\ncount: {count}\nin stock?: {inStock}\ndiscount: {discount}";
            }
        }
        public static double Get()
        {
            bool[] errors = new bool[3];

            Console.Write("Введите название товара: ");
            string name = Console.ReadLine();

            Console.Write("Введите стоимость единицы: ");
            bool firstResult = double.TryParse(Console.ReadLine(), out double price);
            errors[0] = firstResult;

            Console.Write("Введите количество товара: ");
            bool secondResult = uint.TryParse(Console.ReadLine(), out uint count);
            errors[1] = secondResult;

            Console.Write("Введите, учавствует ли товар в акции(true/false): ");
            bool thirdResult = bool.TryParse(Console.ReadLine(),out bool inStock);
            errors[2] = thirdResult;

            if (errors.Contains(false)) throw new Exception($"Одно из значений было введено неправильно!");

            uint discount = 0;

            discount = count >= 5 ? discount + 10 : discount;

            discount = inStock ? discount + 15 : discount;
            

            Receipt receipt = new Receipt(name, price, count, inStock, discount);

            //Console.WriteLine(receipt);
            return receipt.Calc();
        }
    }
}