using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNikola
{
    public class Math
    {
        public int Sabiranje(int a, int b)
        {
            return a + b;
        }
        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public IEnumerable<int> VratiNeparneBrojeve(int granica)
        {
            for(int i=0; i <= granica; i++)
            {
                if (i % 2 != 0)
                    yield return i; //yeald zbog IEnumerable<>
            }
        }
    }
}
