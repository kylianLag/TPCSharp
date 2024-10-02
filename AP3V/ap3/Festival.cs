using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ap3
{
    class Festival
    {

        public List<Realisateur> ListeRealisateur;
        public List<Film> ListeFilm;

        public Festival()
        {

            ListeRealisateur = new List<Realisateur>();
            ListeFilm = new List<Film>();
        }
        public void Fichier()
        { 
      
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Wallon\Desktop\film.csv"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                Film film = new Film(values[0], values[2], values[3], values[4]);

                this.ListeFilm.Add(film);
                

            }
           
        }


        /* public void filmTrier()
         {
             this.ListeFilm.Sort();
             foreach (var film in this.ListeFilm)
             {
                 Console.WriteLine(film);
             }
         }
        */

        public void afficherToutFilm()
        {
            Console.WriteLine("La liste de tout les film :");
           

            foreach (Film f in this.ListeFilm)
            {
                Console.WriteLine(f);
            }
        }

        public void AfficherFilmDate(string date)
        {
            Console.WriteLine("La liste de tout les de la date choisie \n :");


            foreach (Film f in this.ListeFilm)
            {
                if (f.GetAnnee() == date)
                {
                    Console.WriteLine(f);
                }

            }
        }

        public void recherchefilm(string chaine)
        {
            Console.WriteLine("La liste de tout les film contenant vos caractere sont :\n :");

            foreach (Film f in this.ListeFilm)
            {
                 string name = f.GetNom_film();
                 

             }
        }





    }
}
