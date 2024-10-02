using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3V
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
       

        public void filmTrier()
        {
            this.ListeFilm.Sort();
            foreach (var film in this.ListeFilm)
            {
                Console.WriteLine(film);
            }
        }





    }
}
