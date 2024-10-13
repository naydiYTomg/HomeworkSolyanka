namespace HomeworkSolyanka.Test
{
    class LightweightDeliveryTests
    {
        [TestCase((uint)10, (uint)2, (uint)5, (uint)2, (uint)4, true)]
        [TestCase((uint)101, (uint)20, (uint)5, (uint)2, (uint)7, false)]
        [TestCase((uint)10, (uint)2, (uint)5, (uint)2, (uint)13, false)]
        [TestCase((uint)50, (uint)60, (uint)40, (uint)12, (uint)18, false)]
        public void Test(uint length, uint width, uint height, uint mass, uint distance, bool expected)
        {
            bool actual = LightweightDelivery.LightweightDelivery.GetTest(length, width, height, mass, distance);
            Assert.AreEqual(expected, actual);
        }
    }
}
