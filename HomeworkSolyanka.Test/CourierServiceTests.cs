namespace HomeworkSolyanka.Test
{
    class CourierServiceTests
    {
        [TestCase((uint)100, (uint)150, (uint)70, (uint)7150)]
        [TestCase((uint)15, (uint)150, (uint)70, (uint)1200)]
        [TestCase((uint)30, (uint)80, (uint)30, (uint)980)]
        public void Test(uint length, uint fixedPrice, uint priceForKM, uint expected)
        {
            uint actual = CourierService.CourierService.GetTest(length, fixedPrice, priceForKM);
            Assert.AreEqual(expected, actual);
        }
    }
}
