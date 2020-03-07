using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEx4q1
{
   public class Client
    {
        String nom;
        String datenaissance;

       
        public Client(string nom, string datenaissance)
        {
            this.Nom = nom;
            this.datenaissance = datenaissance;
        }

        
        public string Datenaissance { get => datenaissance; set => datenaissance = value; }
        public string Nom { get => nom; set => nom = value; }

        public Boolean reservation(Hotel h,Chambre c, String datedebut,String datefin,int duree)
        {
            Boolean avail = c.Isreserved;
            if (!avail)
                return false;
            else
            {
                Reservation r = new Reservation(datedebut, datefin, duree);
                c.Current = r;
                c.Isreserved = true;
                return true;
            }
        }


    }
}
