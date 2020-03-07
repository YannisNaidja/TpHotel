using System;
using System.Collections.Generic;

namespace ConsoleEx4q1
{
    public class Program
    {
        const int NBHOTELS = 4;
        static void Main(string[] args)
        {
            String num;
            int val = 0;
            Boolean chose = false;
            while (!chose)
            {
                Console.WriteLine("Bonjour, Choissisez un hotel: ");
                Console.WriteLine("Hotel 1 : Ibis Montpellier ");
                Console.WriteLine("Hotel 2 : Hilton Monaco");
                Console.WriteLine("Hotel 3 : Renaissance Aix en Provence ");
                num = Console.ReadLine();
                val = Convert.ToInt32(num);
                Console.WriteLine("val vaut " + val);
                if (val < 0 || val > 3)
                {
                    Console.WriteLine("Entrez un numéro d'hotel entre 1 et " + NBHOTELS);
                }
                else
                {
                    Console.WriteLine("vous avez choisi l'hotel numero " + val);
                    chose = true;
                }
            }

            switch (val)
            {
                case 1:
                    Chambre h1c1 = new Chambre(2, 80);
                    Chambre h1c2 = new Chambre(4, 100);
                    Chambre h1c3 = new Chambre(2, 90);
                    List<Chambre> h1lc = new List<Chambre>(3);
                    h1lc.Add(h1c1);
                    h1lc.Add(h1c2);
                    h1lc.Add(h1c3);
                    Hotel h1 = new Hotel("Ibis", "Montpellier", "Place de la Comédie", 3, h1lc);
                    h1.reservation();
                    break;
                case 2:
                    Chambre h2c1 = new Chambre(2, 80);
                    Chambre h2c2 = new Chambre(4, 100);
                    Chambre h2c3 = new Chambre(2, 90);
                    List<Chambre> h2lc = new List<Chambre>(3);
                    h2lc.Add(h2c1);
                    h2lc.Add(h2c2);
                    h2lc.Add(h2c3);
                    Hotel h2 = new Hotel("Hilton", "Monaco", "Place de la Principauté", 5, h2lc);
                    h2.reservation();
                    break;

                case 3:
                    Chambre h3c1 = new Chambre(2, 80);
                    Chambre h3c2 = new Chambre(4, 100);
                    Chambre h3c3 = new Chambre(2, 90);
                    List<Chambre> h3lc = new List<Chambre>(3);
                    h3lc.Add(h3c1);
                    h3lc.Add(h3c2);
                    h3lc.Add(h3c3);
                    Hotel h3 = new Hotel("Renaissance", "Aix en Provence", "Coursmirabeau", 5, h3lc);
                    h3.reservation();
                    break;
            }
        }
    }
}
