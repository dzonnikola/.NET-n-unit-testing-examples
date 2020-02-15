using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNikola
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin == true || user == MadeBy);
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
