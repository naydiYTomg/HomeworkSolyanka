namespace HomeworkSolyanka.Test
{
    class PositiveNumberWhoseSquareLessThanGivenTests
    {
        [TestCase(4, 2)]
        [TestCase(0, 0)]
        [TestCase(120, 11)]
        public void Test(int number, int expected)
        {
            int actual = PositiveNumsWhSqLsThanGiven.PositiveNumberWhoseSquareLessThanGiven.GetTest(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
