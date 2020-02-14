using System;
using Dimitrije;
using NUnit.Framework;

namespace TestNikolaTests
{
    [TestFixture]
    public class TesterBre
    {
        [Test]
        [TestCase(30)]
        [TestCase(-45)]
        public void Ispis_DeljivoSa3i5_VracaTesterBre(int n)
        {
            var result = Dimitrije.TesterBre.Ispis(n);

            Assert.AreEqual(result, "TesterBre");
        }
        [Test()]
        public void Ispis_DeljivoSa3_VracaTester()
        {
            var result = Dimitrije.TesterBre.Ispis(3);

            Assert.AreEqual(result, "Tester");
        }
        [Test()]
        public void Ispis_DeljivoSa5_VracaBre()
        {
            var result = Dimitrije.TesterBre.Ispis(5);

            Assert.AreEqual(result, "Bre");
        }
        [Test()]
        [TestCase(2)]
        public void Ispis_NijeDeljivo_VracaBrojToString(int broj)
        {
            var result = Dimitrije.TesterBre.Ispis(broj);

            Assert.AreEqual(result, broj.ToString());
        }
    }
}
