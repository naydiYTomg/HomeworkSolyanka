namespace HomeworkSolyanka.Test
{
    class NODFinderTests
    {
        [TestCase(141, 20, 1)]
        [TestCase(321, 96, 3)]
        [TestCase(993, 30, 3)]
        public void Test(int firstNum, int secondNum, int expected)
        {
            int actual = NODFinder.NODFinder.GetTest(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }
    }
}
