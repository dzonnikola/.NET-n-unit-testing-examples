using TestNikola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNikola.Tests
{
    [TestFixture()]
    public class MathTests
    {
        [Test()]
        public void VratiNeparneBrojeveTest()
        {
            //Arrange
            Math m = new Math();
            //Act
            var result = m.VratiNeparneBrojeve(5);
            //Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result, Is.EquivalentTo(new [] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);

        }
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        public void Sabiranje(int a, int b, int expected)
        {
            //Arrange
            Math m = new Math();
            //Act
            var result = m.Sabiranje(a,b);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(3, 4, 4)]
        public void Max(int a, int b, int expected)
        {
            //Arrenge
            Math m = new Math();
            //Act
            var result = m.Max(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}