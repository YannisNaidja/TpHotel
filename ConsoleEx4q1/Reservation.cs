using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEx4q1
{
  public class Reservation
    {
        String date_debut;
        String date_fin;
        int durée_jour;

        public Reservation(string date_debut, string date_fin, int durée_jour)
        {
            this.date_debut = date_debut;
            this.date_fin = date_fin;
            this.durée_jour = durée_jour;
        }
    }
}
