using NUnit.Framework;
using Dimitrije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitrije.Tests
{

    [TestFixture()]
    public class TrkackiPoeniTests
    {
        [Test()]
        [TestCase(-42)]
        [TestCase(-1)]
        [TestCase(351)]

        public void RacunajPoeneTest_BrzinaVanGranica_ThrowArugmentOutOfRangeException(int brzina)
        {
            TrkackiPoeni t = new TrkackiPoeni();
            Assert.That(() => t.RacunajPoene(brzina), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test()]
        [TestCase(0, 0)]
        [TestCase(42, 0)]
        [TestCase(64,0)]
        [TestCase(65, 0)]
        [TestCase(75, 2)]
        [TestCase(340, 55)]

        public void RacunajPoeneTest_PriPozivu_ReturnPoeni(int brzina, int points)
        {
            TrkackiPoeni t = new TrkackiPoeni();
            var result = t.RacunajPoene(brzina);
            Assert.That(result, Is.EqualTo(points));
        }

    }
}