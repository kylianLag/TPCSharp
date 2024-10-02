using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Joueur
    {
        //créer la liste des attributs (ancienne méthode)
        /*private string Pseudo;
        private bool EstUno;
        private Joueur JoueurPrecedent;
        private Joueur JoueurSuivant;

        public string GetPseudo()
        {
            return this.Pseudo;
        }

        public void SetPseudo(string Pseudo)
        {
            this.Pseudo = Pseudo;
        }*/

        //créer les accesseurs (ancienne méthode)
        //Version hybride (attributs + accesseurs) 
        //attribut de base
        public string Pseudo { get; set; }
        public bool EstUno { get; set; }
        public Joueur JoueurPrecedent { get; set; }
        public Joueur JoueurSuivant { get; set; }

        //attribut de liaison
        public List<Carte> MainJoueur { get; set; } //(1)

        //contructeur par défaut
        public Joueur(string pseudo, bool estUno)
        {
            this.Pseudo = pseudo;
            this.EstUno = estUno;
            //valeur par défaut en attendant un bon paramètrage
            this.JoueurPrecedent = this;
            this.JoueurSuivant = this;
            //(2)
            this.MainJoueur = new List<Carte>();
        }

        public Joueur(string pseudo, bool estUno, Joueur joueurPrecedent)
        {
            this.Pseudo = pseudo;
            this.EstUno = estUno;
            //valeur par défaut en attendant un bon paramètrage
            this.JoueurPrecedent = joueurPrecedent;
            this.JoueurSuivant = this;
            this.MainJoueur = new List<Carte>();
        }

        public Joueur(string pseudo, bool estUno, Joueur joueurPrecedent, Joueur joueurSuivant)
        {
            this.Pseudo = pseudo;
            this.EstUno = estUno;
            //valeur par défaut en attendant un bon paramètrage
            this.JoueurPrecedent = joueurPrecedent;
            this.JoueurSuivant = joueurSuivant;
            this.MainJoueur = new List<Carte>();
        }

        //(4) methode d'ajout de carte
        public void AddCarte(Carte carte)
        {
            this.MainJoueur.Add(carte);
        }

        

        //méthodes.
        public string ToString()
        {
            string rtr = "[Pseudo]: " + this.Pseudo + "\n" +
                "[Est Uno] : " + this.EstUno + "\n" +
                "[Joueur Précedent] : " + this.JoueurPrecedent.Pseudo + "\n" +
                "[Joueur Suivant] : " + this.JoueurSuivant.Pseudo + "\n";
            //(3)
            //boucle pour chaque carte de la main du joueur on veut le détail
            foreach (Carte c in this.MainJoueur)
            {
                rtr += "[Carte] : " + c.ToString() + "\n";
            }
            return rtr;
        }

        public string AfficherMain()
        {
            string str = "";
            foreach(Carte c in this.MainJoueur)
            {
                 
                str += c.Valeur + c.Couleur[0] + " | ";
            }
            return str;
        }

    }
}
