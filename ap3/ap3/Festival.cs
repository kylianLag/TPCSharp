using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3
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

        string lien = (@"C:\Users\Wallon\Desktop\film.csv");
        public void Fichier()
        { 
      
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Wallon\Desktop\film.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                bool espace = false;
                string prenom = "";
                string nom = "";
                for(int i = 0; i < values[1].Length; i++)
                {
                    if (values[1][i] != ' ')
                    {
                        prenom = prenom + values[1][i];
                    }
                    else
                    {
                        espace = true;
                        prenom=prenom+" ";
                    }

                    if(espace == true)
                    {
                        nom = nom + values[1][i];
                    }
                }
                Realisateur rea = new Realisateur(prenom, nom);
                Film film = new Film(values[0], values[2], values[3], values[4] , rea );

                this.ListeFilm.Add(film);


            }
            reader.Close();
           
        }
       

        public void filmTrier()
        {
            this.ListeFilm.Sort();
            foreach (var film in this.ListeFilm)
            {
                Console.WriteLine(film);
            }
        }

        public void FilmDuRealisateur(string nom, string prenom)
        {
            foreach(Film film in this.ListeFilm)
            {
                foreach(Realisateur real in this.ListeRealisateur)
                {
                    if (real.getNom() == nom && real.getPrenom() == prenom)
                    {
                        Console.WriteLine(film);
                    }
                }
            }
        }

        public void AjouterFilm()
        {
            
            Console.Write("Entrez le titre du film: ");
            string titre = Console.ReadLine();
            Console.Write("Entrez le nom du réalisateur: ");
            string nomRea = Console.ReadLine();
            Console.Write("Entrez le prénom du réalisateur: ");
            string prenomRea = Console.ReadLine();
            Realisateur rea = new Realisateur(prenomRea,nomRea);
            Console.Write("Entrez la section: ");
            string section = Console.ReadLine();
            Console.Write("Entrez le prix: ");
            string prix = Console.ReadLine();
            Console.Write("Entrez l'année: ");
            string annee = Console.ReadLine();

           if (!ListeRealisateur.Contains(rea)) { 
                    ListeRealisateur.Add(rea);
           }
 
            Film film = new Film(titre, section, prix, annee , rea);
            rea.AjouterFilm(film);
            ListeFilm.Add(film);
            Console.WriteLine("Film ajouté avec succès.");

           foreach(Film f in ListeFilm)
            {
                Console.WriteLine(f);
            }

        }


       public void SupprimerFilm(Film film)
        {
                ListeFilm.Remove(film);
                film.Realisateur.supprimerFilm(film);
                Console.WriteLine("Film supprimé avec succès.");

        }

         public  void ListeFilmsParAnnee(string annee)

         {

            foreach(Film f in ListeFilm)
            {
                
                if(Convert.ToString(f.GetAnnee())== annee)
                {
                    Console.WriteLine(f);
                }
            }

        }

        public void Save()
        {
           
            StreamWriter writer = new StreamWriter(lien);

        {

                foreach (Film film in ListeFilm)

                {

                    writer.WriteLine($"{film.GetNom_film()};{film.GetRea_film()};{film.GetNom_section()};{film.GetNom_prix()};{film.GetAnnee()}");

                }

            }

            Console.WriteLine("Changements sauvegardés. Au revoir!");

        }







    }
}
