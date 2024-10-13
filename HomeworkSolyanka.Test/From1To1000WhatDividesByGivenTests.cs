namespace HomeworkSolyanka.Test
{
    class From1To1000WhatDividesByGivenTests
    {
        //const int[] expectedd = Enumerable.Range(1, 1000).ToArray();
        [TestCase(100, new int[]{100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        public void Test(int number, int[] expected)
        {
            int[] actual = Fr1t1000.From1To1000WhatDividesByGiven.GetTest(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
