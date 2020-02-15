using System;

namespace Dimitrije
{
    public class TrkackiPoeni
    {
        private const int donjaGranica = 65;
        private const int gornjaGranica = 350;
        
        
        public int RacunajPoene(int brzina)
        {
            if (brzina < 0 || brzina>gornjaGranica) 
                throw new ArgumentOutOfRangeException();
            
            if (brzina <= donjaGranica) return 0; 
            
           const int kmPoPoenu = 5;
            var poeni = (brzina - donjaGranica)/kmPoPoenu;

            return poeni;
        }        
    }
}