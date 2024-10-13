namespace HomeworkSolyanka.Test
{
    class TableReservationTests
    {
        [TestCase((uint) 2, 1)]
        [TestCase((uint) 3, 2)]
        [TestCase((uint) 9, 0)]
        public void Test(uint count, int expected)
        {
            int actual = TableReservation.TableReservation.GetTest(count);
            Assert.AreEqual(expected, actual);
        }
    }
}
