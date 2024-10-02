using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Festival festival = new Festival();
            festival.Fichier();
            

            foreach(Film f in festival.ListeFilm)
            {
                Console.WriteLine(f);
            }


            festival.AjouterFilm();
            festival.ListeFilmsParAnnee("2014");
            festival.Save();


        }

    }
}

