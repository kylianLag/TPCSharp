using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Pioche
    {
        public bool Estvide { get; set; }
        public List<Carte> ListCartePio { get; set; }

        public Pioche()
        {
            //remplir la pioche (la liste des cartes)
            this.ListCartePio = new List<Carte>();
            RemplirCartes();
            Estvide = false;
            //on va utiliser une sous fonction interne
        }

        private void RemplirCartes()
        {
            //rappel on veut ajouter toutes les cartes dans la pioche 
            //4 couleur : 0-9 Ø § +2 (x2)
            //noir : +4 joker (x4)
            //Rappel pour les boucles

            //faire trois listes
            List<string> ListCouleur = new List<string>();
            ListCouleur.Add("rouge");
            ListCouleur.Add("jaune");
            ListCouleur.Add("vert");
            ListCouleur.Add("bleu");

            List<string> ListValeur = new List<string>();

            //amélioration
            for (int i = 0; i < 10; i++)
            {
                ListValeur.Add(i.ToString());
            }
            ListValeur.Add("Ø");
            ListValeur.Add("§");
            ListValeur.Add("+2");

            List<string> ListValeurNoir = new List<string>();
            ListValeurNoir.Add("+4");
            ListValeurNoir.Add("Jocker");

            //1ere boucle sur les couleurs
            foreach (string coul in ListCouleur)
            {
                //deux fois l'opération
                for (int i = 0; i < 2; i++)
                {
                    //2eme boucle sur les valeurs
                    foreach (string val in ListValeur)
                    {
                        //TODO : gérer l'affichage des effets
                        //si = +2 ou Ø ou § on doit indiquer l'effet (petite phrase)
                        string effet = "";

                        if (val == "+2")
                        {
                            effet = "Le prochain joueur pioche 2 cartes";
                        }
                        else if (val == "Ø")
                        {
                            effet = "Le prochain joueur passe son tour";
                        }
                        else if (val == "§")
                        {
                            effet = "on change le sens des joueurs";
                        }
                        Carte carte = new Carte(coul, val, effet);
                        ListCartePio.Add(carte);
                    }
                    /*foreach (string val in ListValeur)
                    {
                        Carte carte;
                        if (val == "+2")
                        {
                            carte = new Carte(coul, val, "Le prochain joueur pioche 2 cartes");
                        }
                        else if (val == "Ø")
                        {
                            carte = new Carte(coul,val, "Le prochain joueur passe son tour");
                        }
                        else if (val == "§")
                        {
                            carte =new Carte(coul,val, "on change le sens des joueurs");
                        }
                        else
                        {
                            carte = new Carte(coul, val, "");
                        }
                        ListCartePio.Add(carte);
                    }*/
                }
            }

            //TODO : prévoir les cartes noires
            for (int i = 0; i < 4; i++)
            {
                foreach (string valNoir in ListValeurNoir)
                {
                    string effet = "";
                    if (valNoir == "+4")
                    {
                        effet = "Le joueur actif choisi sa couleur puis le prochain " +
                            "joueur pioche 4 cartes et passe son tour";
                    }
                    else if (valNoir == "Jocker")
                    {
                        effet = "Le joueur actif choisi sa couleur";
                    }
                    Carte c = new Carte("noir", valNoir, effet);

                    ListCartePio.Add(c);
                }
            }


        }

        public override string ToString()
        {
            string rtr = "[Est vide ?] : " + this.Estvide.ToString() + "\n [Carte] :";
            foreach (Carte c in ListCartePio)
            {
                rtr += c.ToString();
            }
            return rtr;
        }
    }
}