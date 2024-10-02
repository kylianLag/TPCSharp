using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    internal class Carte
    {
        private string couleur { get; set; }
        private string valeur { get; set; }
        private string effet { get; set; }

        public Carte(string couleur, string valeur, string effet)
        {
            this.couleur = couleur;
            this.valeur = valeur;
            this.effet = effet;
        }

        public string toString()
        {
            return "Couleur : " + this.couleur + "\nValeur : " + this.valeur + "\nEffet : " + this.effet;
        }
    }
}
