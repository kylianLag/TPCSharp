using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Carte
    {
        public string Couleur { get; set; }
        public string Valeur { get; set; }
        public string Effet { get; set; }

        public Carte(string couleur, string valeur, string effet)
        {
            this.Couleur = couleur;
            this.Valeur = valeur;
            this.Effet = effet;
        }

        public override string ToString()
        {
            return "[Couleur] : " + this.Couleur + "\n" +
                "[Valeur] : " + this.Valeur + "\n" +
                "[Effet] : " + Effet + "\n";
        }
    }
}
