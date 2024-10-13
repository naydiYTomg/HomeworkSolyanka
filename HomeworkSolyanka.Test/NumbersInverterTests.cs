namespace HomeworkSolyanka.Test
{
    class NumbersInverterTests
    {
        [TestCase("1092", "2901")]
        [TestCase("29000", "92")]
        [TestCase("7562", "2657")]
        public void Test(string input, string expected)
        {
            string actual = NumbersInverter.NumbersInverter.GetTest(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
