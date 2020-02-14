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
    public class HtmlStringFormaterTests
    {
        [Test()]
        public void FormatirajBoldTest()
        {
            HtmlStringFormater h = new HtmlStringFormater();

            var result = h.FormatirajBold("nikola");

            Assert.That(result, Is.EqualTo("<strong>nikola</strong>").IgnoreCase);

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("nikola"));
        }
    }
}