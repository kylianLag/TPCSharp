using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPUno
{
    public class Partie
    {
        //aucun attribut de base
        //que des attributs de liaisons

        //1..n
        public List<Joueur> lstJoueurs {  get; set; } 

        //1..1
        public Defausse defausse { get; set; } 
        public Pioche pioche { get; set; }

        public Partie(Pioche pioche , Defausse defausse)
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

        public void distributionInitial()
        {
            foreach(Joueur joueur in lstJoueurs)
                for(int i = 0; i < 7; i++)
                {
                    PiocherCarte(joueur);
                }
            
        }
    }
}
