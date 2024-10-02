using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPUno
{
    public class Defausse
    {
        public List<Carte> listeDefausse {  get; set; } 
        public Defausse ()
        {
            listeDefausse = new List<Carte> ();
        }

        public void AddCarte(Carte carte)
        {
            this.listeDefausse.Add (carte);
        }

        public override string ToString()
        {
            string rtr = "";
            foreach (Carte carte in listeDefausse) 
            { 
                rtr+= carte.ToString(); 
            }
            return rtr;
        }
    }
}
