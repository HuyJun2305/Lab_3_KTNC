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


        // B�i 1
        [Test]
        public void TestIntNumber()
        {
            int a = 5;
            int b = 10;
            int expected = 15;
            Assert.AreEqual(expected, _kts.SumInt(a, b));
        }


        // B�i 2
        [Test]
        public void TestQuoitient()
        {
            double a = 5;
            double b = 10;
            double expected = 0.5;
            Assert.AreEqual(expected, _kts.Quoitient(a, b));

        }




    }   
}