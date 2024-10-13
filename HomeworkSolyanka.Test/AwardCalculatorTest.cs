namespace HomeworkSolyanka.Test
{
    public class AwardCalculatorTest
    {
        [TestCase(1000, 2000, 100)]
        [TestCase(10000, 4000, 0)]
        [TestCase(3999, 6999, 300)]
        [TestCase(4000, 4993, 99.3)]
        public void Test(int soldPlan, int monthSolds, double expected)
        {
            double actual = AwardCalculator.AwardCalculator.GetTest(soldPlan, monthSolds);
            Assert.AreEqual(expected, actual);
        }
    }
}