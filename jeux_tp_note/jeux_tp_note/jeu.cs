using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_tp_note
{
    class jeu
    {
        private List<zone> ListeZone;
        private Joueur joueur;

        public jeu(Joueur joueur)
        {
            ListeZone = new List<zone>();
            this.joueur = joueur;
        }


        public void afficherZone()
        {
            foreach (zone t in ListeZone)
            {
                Console.WriteLine(t);
                
            }
        }

        public void changerZone(zone zone)
        {
            joueur.setZone(zone);
        }

        public void rencontreAleatoire()
        {
            Random aleatoire = new Random();
            
            zone a =joueur.getZone();
            int alea = aleatoire.Next(a.listmonstre());
           monstre monstre = a.choixMonstreIndice(alea);
           Console.WriteLine("vous rencontrer un " + monstre);
            Console.WriteLine("Les stats du monstre sont : "+ monstre.ToString());
            while (joueur.getVie()>0 && monstre.getVie() > 0)
            {
                Console.WriteLine("plusieur choix s'offrent a vous , vous voulez : 1 Attaquer ; 2 vous soigner ; 3 fuir");
                int choix = Convert.ToInt32(Console.ReadLine());
                if(choix == 1)
                {
                    
                    joueur.attaquerMonstre(monstre);
                }
            }
            
            
        }
    }
}
