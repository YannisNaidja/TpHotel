using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEx4q1
{
    public class Hotel
    {
        String nom;
        String ville;
        String adresse;
        int nbetoiles;
        List<Chambre> Chambres;

        public Hotel(string nom, string ville, string adresse, int nbetoiles, List<Chambre> chambres)
        {
            this.Nom = nom;
            this.Ville = ville;
            this.Adresse = adresse;
            this.Nbetoiles = nbetoiles;
            Chambres = chambres;
        }

        public string Ville { get => ville; set => ville = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Nbetoiles { get => nbetoiles; set => nbetoiles = value; }
        

        public void reservation()
        {
            Console.WriteLine("Bienvenue dans l'hôtel " + nom + "situé à " + ville);
            Console.WriteLine("Veuillez entrer le nombre de lits demandé");
            String snblitask = Console.ReadLine();
             int nblitask = Convert.ToInt32(snblitask);

            foreach (Chambre c in Chambres)
            {
               
                if(c.Nblits == nblitask && c.Isreserved == false)
                {
                    Boolean loop = true;
                    
                    Console.WriteLine("Une chambre est disponible aux prix de "+ c.Prix);
                    // cas des dates de reservation 
                    while (loop) {
                        Console.WriteLine("Confrimez vous la réservation ? Entrez oui ou non");
                        String rep = Console.ReadLine();
                        if (rep.Equals("oui")){
                            Console.WriteLine("La chambre vous est reservée!");
                            Console.WriteLine("Voulez-vous regarder si une autre chambre avec ce nombre de lits est disponible?");
                            String rep1 = Console.ReadLine();
                            if (rep1.Equals("non"))
                            {
                                return;
                            }
                            else
                            {
                                loop = false;
                            }
                        }

                        else if (rep.Equals("non"))
                        {
                            Console.WriteLine("La réservation est annulée!");
                            Console.WriteLine("Voulez-vous regarder si une autre chambre avec ce nombre de lits est disponible?");
                            String repno = Console.ReadLine();
                            if (repno.Equals("non"))
                            {
                                return;
                            }
                            else
                            {
                                loop = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrez oui ou non pour valider");
                        }
                    }
                }
                
            }
            
              Console.WriteLine("Nous n'avons pas de chambre correspondant à votre requête");
            
        }
        
    }
}
