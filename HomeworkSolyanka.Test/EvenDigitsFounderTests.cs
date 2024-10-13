
namespace HomeworkSolyanka.Test
{
    class EvenDigitsFounderTests
    {
        [TestCase(1010, 2)]
        [TestCase(4020, 0)]
        [TestCase(315793, 6)]
        public void Test(int number, int expected)
        {
            int actual = EvenDigitsFounder.EvenDigitsFounder.GetTest(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
