using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ap3
{
    class Program
    {

       
        static void Main(string[] args)
        {
            Festival festival = new Festival();
            festival.Fichier();
            festival.afficherToutFilm();


            Console.WriteLine("choississez une date \n");
            string date = Console.ReadLine();
            festival.AfficherFilmDate(date);

            Console.WriteLine("veuillez ecrire les caracteres de recherche :");
            string chaine = Console.ReadLine();

            festival.recherchefilm(chaine);

            

            


        }
        

       

        

    }
}

