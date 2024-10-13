namespace HomeworkSolyanka.Test
{
    class NDForOneFinderTests
    {
        [TestCase(70, 35)]
        [TestCase(993, 331)]
        [TestCase(7522, 3761)]
        public void Test(int number, int expected)
        {
            int actual = NDForOneFinder.NDForOneFinder.GetTest(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
