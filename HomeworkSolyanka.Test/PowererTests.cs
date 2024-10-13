namespace HomeworkSolyanka.Test
{
    class PowererTests
    {
        [TestCase((uint) 11, (uint) 2, 121)]
        [TestCase((uint) 3, (uint) 3, 27)]
        [TestCase((uint) 5, (uint) 3, 125)]
        public void Test(uint number, uint power, double expected)
        {
            double actual = Powerer.Powerer.GetTest(number, power);
            Assert.AreEqual(expected, actual);
        }
    }
}
