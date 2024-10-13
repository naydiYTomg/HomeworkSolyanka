namespace HomeworkSolyanka.Test
{
    class DepositCalculatorTests
    {
        [TestCase((uint)2500, (uint)1500)]
        [TestCase((uint)8000, (uint)4800)]
        [TestCase((uint)12955, (uint)7765)]
        public void Test(uint vklad, uint expected)
        {
            uint actual = DepositCalculator.DepositCalculator.GetTest(vklad);
            Assert.AreEqual(expected, actual);
        }
    }
}
