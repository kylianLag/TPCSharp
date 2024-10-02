using System;


//declaration de la classe
namespace intro_objet// name space pour plusieur class dans fichier differents
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //declaration objet voiture

            voiture mavoiture = new voiture("R5", "Renault", "jaune", "electrique", 15.5, 50.0);

            //affichage voiture

            Console.WriteLine(mavoiture.ToString());

            //mavoiture.setModele("R6");

            // Console.WriteLine(mavoiture.ToString());

              voiture mavoiture2 = new voiture("R6", "Mercedes", "rouge", "electrique", 15.5,70);

            //  Console.WriteLine(mavoiture2.ToString());
            /*Console.WriteLine("saisir un volume");
            double volume = Convert.ToDouble(Console.ReadLine());

            if (mavoiture.remplirCoffre(volume))
            {
                Console.WriteLine(mavoiture.ToString());
                
            }
            else
            {
                Console.WriteLine("le volume demander est trop grand");
            }
            Console.WriteLine(mavoiture.faireLePlein(volume, "electrique"));
            */

            Garage garage1 = new Garage("renault", "valenciennes");
            garage1.ajouterVoiture(mavoiture);
            garage1.ajouterVoiture(mavoiture2);
            Console.WriteLine(garage1.ToString());
            Console.WriteLine(garage1.capaciteTotalVoiture());
           

        }
    }

}

