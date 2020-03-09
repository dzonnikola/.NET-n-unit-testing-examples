using NUnit.Framework;
using TestNikola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNikola.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_KadaJePozvan_PostaviLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Log_StringNull_ThrowNullArgumentException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
        
        [Test]
        public void Log_ValidError_RaiseErrorLoggerEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}