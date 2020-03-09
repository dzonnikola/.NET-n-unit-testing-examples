using NUnit.Framework;
using TestNikola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestNikola.CustomerControl;

namespace TestNikola.Tests
{
    [TestFixture]
    public class CustomerControlTests
    {
        [Test]
        public void VratiCustomer_IdJeNula_VratiNotFound()
        {
            var controler = new CustomerControl();

            var result = controler.VratiCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());

            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void VratiCustomer_IdNijeNula_VratiOk()
        {
            var controler = new CustomerControl();

            var result = controler.VratiCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());

            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}