using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Partie
    {
        //aucun attribut de base
        //que des attributs de liaisons

        //1..n
        public List<Joueur> lstJoueurs { get; set; }

        //1..1
        public Defausse defausse { get; set; }
        public Pioche pioche { get; set; }

        public Partie(Pioche pioche, Defausse defausse)
        {
            this.defausse = defausse;
            this.pioche = pioche;
            this.lstJoueurs = new List<Joueur>();
            
        }

        public void AjouterJoueur(Joueur joueur)
        {
            this.lstJoueurs.Add(joueur);
        }

        public void Melanger()
        {
            //creation et appel de l'objet random (Random) + initialisation (new)
            Random rdm = new Random();
            //creation de la listemelangée + initialisation (new)
            List<Carte> listMelCarte = new List<Carte>();
            //boucle avec le for
            //i = taille de la listepioche ; i > 0 ; i --

            for (int i = pioche.ListCartePio.Count(); i > 0; i--)
            {
                //création d'une valeur random a l'aide de random entre 0 et i (taille de pioche)
                int rdmvalue = rdm.Next(0, i);
                //on récupère la carte de la listepioche (on utilise les [] )
                Carte carte = pioche.ListCartePio[rdmvalue];
                //on l'ajoute à la listemelagee
                listMelCarte.Add(carte);
                //on removeat l'index du rdm.
                pioche.ListCartePio.RemoveAt(rdmvalue);
            }

            //après la boucle on remplace listepioche par listemelangee (on utilise l'accesseur)
            this.pioche.ListCartePio = listMelCarte;
        }

        public bool PiocherCarte(Joueur j)
        {
            if (this.pioche.ListCartePio.Count == 0)
            {
                //on a pas pu piocher (on le changer sous forme d'erreur / exception)
                return false;
            }
            j.AddCarte(this.pioche.ListCartePio[0]);
            this.pioche.ListCartePio.Remove(pioche.ListCartePio[0]);
            //TODO : retourne faux si la carte n'est pas directement jouable
            return false;
        }

        private void distributionInitial()
        {
            foreach (Joueur joueur in lstJoueurs)
                for (int i = 0; i < 7; i++)
                {
                    PiocherCarte(joueur);
                }

        }

        public void Jouercarte(Joueur joueur , Carte carte)
        {
            //gestion du tour (plus tard)
            // s'assure que la carte jouer est dans la carte du joueur
            if (this.lstJoueurs.Contains(joueur))
            {
                if (joueur.MainJoueur.Contains(carte))
                {
                    Carte carteDefausse = this.defausse.listeDefausse.Last<Carte>();
                    //la methode va verifier que la carte correspond a la derniere carte de la defause cad meme couleur ou meme symbole
                    
                    if (carte.Couleur == carteDefausse.Couleur || carte.Valeur == carteDefausse.Valeur)
                    {
                        //on doit defausser la carte du joueur donc on retir la carte de la main joueur pour l'ajouter a la defausse
                        joueur.MainJoueur.Remove(carte);
                        defausse.listeDefausse.Add(carte);
                        //risque sur le fait qu'on manipule le joueur du paramétre et pas de la partie
                        
                    }else if (carteDefausse.Couleur == "noir")//on accept sans verif les cartes noir
                    {
                        joueur.MainJoueur.Remove(carte);
                        defausse.listeDefausse.Add(carte);
                    }
                    else
                    {
                        Console.WriteLine("\nCe n'est pas possible \n");
                    }
                }
            }
            
            //TODO :gerer effets
            
        
            

        }

        public void DebutPartie()
        {
            //methode principal 
            //combien de joueur
            // on affect directement l'odre des joueur
            // distribution initial 
            //on ajoute 1 carte a la defausse (si carte noir on continue)
            //on va designer le premier joueur
            //tant que les joueurs ont des cartes en main
            //on fait le tour
            //joueur en cour : jouer() , piocheer() , uno()
            // fin de tour = joueursuivant
            Console.WriteLine("Bienvenue dans l'application du Uno \n");
            Console.WriteLine("\nCombien de joueur ?\n");
            int nombreJoueur = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<nombreJoueur; i++)
            {
                Console.WriteLine("\nIndiquer le nom joueur " + i+ "\n");
                string nomJoueur = Console.ReadLine();
                Joueur Joueur = new Joueur(nomJoueur, false);
                this.lstJoueurs.Add(Joueur);
            }

            for(int i = 0; i < this.lstJoueurs.Count; i++)
            {
                //exeption si i = 0 ou i = count
                if(i == 0)
                {
                    this.lstJoueurs[i].JoueurPrecedent = this.lstJoueurs[this.lstJoueurs.Count];
                    this.lstJoueurs[i].JoueurSuivant = this.lstJoueurs[i + 1];


                }
                else if(i == this.lstJoueurs.Count - 1)
                {
                    this.lstJoueurs[i].JoueurSuivant = this.lstJoueurs[0];
                    this.lstJoueurs[i].JoueurPrecedent = this.lstJoueurs[i - 1];


                }
                else
                {
                    this.lstJoueurs[i].JoueurSuivant = this.lstJoueurs[i + 1];
                    this.lstJoueurs[i].JoueurPrecedent = this.lstJoueurs[i - 1];
                }
                distributionInitial();
                Carte carteADefausser = this.pioche.ListCartePio.Last<Carte>();
                this.pioche.ListCartePio.Remove(carteADefausser);
                Joueur joueurCourant = this.lstJoueurs[0];
                while(ContinuerPartie() == true)
                {
                   
                    this.lstJoueurs[i].AfficherMain();
                }
                //affichage fin de partie
                int reponse = Convert.ToInt32(Console.ReadLine());
                if(reponse == 1)
                {
                    //gerer la pioche (methode deja fait)
                    PiocherCarte(joueurCourant);
                    //fin de tour
                    joueurCourant = joueurCourant.JoueurSuivant;
                }else if(reponse == 2)
                {
                    //on va lui demander quel carte et en fonction de la carte on appelle jouercarte on peut faire fin de tour
                    Console.WriteLine("Quelle carte ? saisir le numero entre parenthese");
                    int res = Convert.ToInt32(Console.ReadLine());
                    Jouercarte(joueurCourant, joueurCourant.MainJoueur[res]);
                }
                else
                {
                    Console.WriteLine("Mauvaise manip reesayer");
                }
                //affichage joueur en cour et de sa main :
                //4R | 5B | +4N etc..

            }
            //on boucle chaque joueur pour recuperer le nombre de carte en main
            //on recupere le joueur avec 0 carte et on l'affiche
            //prevoir un affichage de fin de partie
            foreach(Joueur jo in lstJoueurs)
            {
                if(jo.MainJoueur.Count == 0)
                {
                    Console.WriteLine("le joueur" + jo.Pseudo + " a gagné");
                }
            }



        }
        private bool ContinuerPartie()
        {
            foreach (Joueur j in this.lstJoueurs)
            {
                if (j.MainJoueur.Count == 0)
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
