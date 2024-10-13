namespace HomeworkSolyanka.Test
{
    class ProductPriceCalculatorTests
    {
        [TestCase(12, (uint) 5, true, 45)]
        [TestCase(24, (uint) 5, true, 90)]
        [TestCase(19.9d, (uint) 3, true, 50.744999999999997d)]
        public void Test(double price, uint count, bool inStock, double expected)
        {
            double actual = ProductPriceCalculator.ProductPriceCalculator.GetTest(price, count, inStock);
            Assert.AreEqual(expected, actual);
        }
    }
}
