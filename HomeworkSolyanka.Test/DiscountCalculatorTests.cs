namespace HomeworkSolyanka.Test
{
    class DiscountCalculatorTests
    {
        [TestCase((uint)40, (uint)7, (uint)5099, true)]
        [TestCase((uint)70, (uint)1, (uint)2099, true)]
        [TestCase((uint)18, (uint)5, (uint)2000, false)]
        public void Test(uint age, uint count, uint spended, bool expected)
        {
            bool actual = DiscountCalculator.DiscountCalculator.GetTest(age, count, spended);
            Assert.AreEqual(expected, actual);
        }
    }
}
