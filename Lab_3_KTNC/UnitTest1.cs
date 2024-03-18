using Calculator;
using NUnit.Framework;
namespace Lab_3_KTNC
{
    public class Tests
    {
        private KiemTraSo _kts;
        [SetUp]

        public void Setup()
        {
            _kts = new KiemTraSo();
        }

        [Test]
        public void TestIntNumber(int a , int b)
        {
            a = 5;
            b = 10;
            int expected = 15;
            Assert.AreEqual(expected, _kts.SumInt(a, b));
        }


    }
}