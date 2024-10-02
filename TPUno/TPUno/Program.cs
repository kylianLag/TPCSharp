using System;
using System.Diagnostics;

namespace TPUno
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Joueur joueur1 = new Joueur("toto", false);
            //affichage sans cartes
            //Console.WriteLine(joueur1.ToString());

            Pioche pio = new Pioche();
            Defausse def = new Defausse();
            Partie partie = new Partie(pio, def);
            //Console.WriteLine(partie.pioche.ToString());
            partie.Melanger();
            Console.WriteLine(partie.pioche.ToString());
        }
    }
}