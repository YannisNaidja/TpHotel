using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEx4q1
{
   public class Chambre
    {
        int nblits;
        int prix;
        Boolean isreserved = false;
        Reservation current = null;

      
        public Chambre(int nblits, int prix)
        {
            this.Nblits = nblits;
            this.Prix = prix;
            
        }

        public bool Isreserved { get => isreserved; set => isreserved = value; }
        public Reservation Current { get => current; set => current = value; }
        public int Prix { get => prix; set => prix = value; }
        public int Nblits { get => nblits; set => nblits = value; }
    }
}
