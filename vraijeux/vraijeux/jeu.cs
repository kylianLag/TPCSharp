using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraijeux
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

            zone a = joueur.getZone();
            int alea = aleatoire.Next(a.listmonstre());
            
            monstre monstre = a.choixMonstreIndice(alea);
            Console.WriteLine("\n vous rencontrer un " + monstre.getNom() + "\n");
            Console.WriteLine("Les stats du monstre sont : " + monstre.getVie() +" HP "+ monstre.getAttaque() + " ATQ " + monstre.getniveauDifficulter() + " en niveau de difficulte "+  "\n");
            bool fuir = false;
            int soin = 3;
            while ((joueur.getVie() > 0 && monstre.estVaincu() == false) && fuir == false)
            {
                Console.WriteLine("plusieur choix s'offrent a vous , vous voulez : 1 Attaquer ; 2 vous soigner ; 3 fuir\n");
                int choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)
                {
                    joueur.attaquerMonstre(monstre);
                    Console.WriteLine("Aprés votre attaque , la vie restante  du monstre a baissé , la voici :\n");
                    Console.WriteLine(monstre.getVie() + "/" + monstre.getVieMax()+ " HP");
                }
                else if (choix == 2)
                {
                    if(soin != 0)
                    {
                        joueur.sesoigner();
                        soin = soin - 1;
                        Console.WriteLine("vous venez de vous soigner , il ne vous reste que " + soin + " utilisations disponible\n");
                    }
                    else
                    {
                        Console.WriteLine("Suite a un manque d'attention , vous n'avez pas vue que vous etiez a cour de soin , pendant ce temps LE MONSTRE VOUS ATTAQUE !\n");
                    }
                    
                }
                else if(choix == 3)
                {
                    if (joueur.fuir())
                    {
                        fuir = true;
                        Console.WriteLine("\n Vous avez reussi a fuir ! votre vie est actuellement de " + joueur.getVie() + "/" + joueur.getVieMax() + "HP");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas reussis a fuir !\n");
                    }
                }
                if(monstre.getVie()> 0)
                {
                    monstre.attaquerJoueur(joueur);
                    Console.WriteLine("le monstre vous a attaquer , voici votre vie actuelle :\n");
                    Console.WriteLine(joueur.getVie() + "/" + joueur.getVieMax() + "HP\n");
                }
                
            }
            if (monstre.estVaincu())
            {
                joueur.setAttaque(joueur.getAttaque() + Convert.ToInt32(monstre.getAttaque() / 7));
                joueur.setVie(joueur.getVie() + Convert.ToInt32(monstre.getVie() / 5));
                joueur.setVieMax(joueur.getVieMax() + Convert.ToInt32(monstre.getVieMax() / 5));
                Console.WriteLine("\n en tuant le monstre vous etes devenue plus fort , voici vos nouvelles statistique ! " + joueur.ToString()+ "\n");
            }
           



        }

            public void ajouterZone(zone zone)
            {
                ListeZone.Add(zone);
            }
            
            
        
    }
}
