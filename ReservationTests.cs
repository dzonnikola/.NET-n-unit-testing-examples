using NUnit;
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
    public class ReservationTests
    {
        [Test()]
        public void CanBeCancelledBy_Admin_True()
        {
            User u = new User();
            u.IsAdmin = true;
            var r = new Reservation();

            bool result = r.CanBeCancelledBy(u);
            Assert.That(result, Is.True);
        }
        public void CanBeCancelledBy_NotAdmin_False()
        {
            User u = new User();
            u.IsAdmin = false;
            var r = new Reservation();

            bool result = r.CanBeCancelledBy(u);
            Assert.That(result, Is.False);
        }

        [Test()]

        public void CanBeCancelledBy_SameUser_True()
        {
            User u = new User();
            u.IsAdmin = true;


        }
        public void CanBeCancelledBy_SameUser_False()
        {

        }

        [Test()]
        public void CanBeCancelledBy_OtherUser_True()
        {

        }
        public void CanBeCancelledBy_OtherUser_False()
        {

        }


    }
}