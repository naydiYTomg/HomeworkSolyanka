namespace HomeworkSolyanka.Test
{
    class SumOfAllNumberFromAtoBWhatDividesBySevenTests
    {
        [TestCase(2, 9, 7)]
        [TestCase(18, 1, 21)]
        [TestCase(20, 40, 84)]
        public void Test(int firstNum, int secondNum, int expected)
        {
            int actual = SumOfAllNumberFromAtoBWhatDividesBySeven.SumOfAllNumberFromAtoBWhatDividesBySeven.GetTest(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }
    }
}
