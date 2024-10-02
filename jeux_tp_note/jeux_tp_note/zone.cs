using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_tp_note
{
    class zone
    {
        string nom;
        private List<monstre> ListeMonstres;

        public zone(string nom)
        {
            this.nom = nom;
            ListeMonstres = new List<monstre>();
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void ajouterMonstre(monstre monstre)
        {
            ListeMonstres.Add(monstre);
        }

        public void retirerMonstre(monstre monstre)
        {
            ListeMonstres.Remove(monstre);
        }
        public override string ToString()
        {
            return " [Nom] : " + this.nom;
        }
        public int listmonstre()
        {
           int Count = 0;
            foreach(monstre monstre in ListeMonstres)
            {
                Count++;
                Console.WriteLine(monstre);
            }
            return Count;
        }

        public monstre choixMonstreIndice(int a)
        {
            return this.ListeMonstres[a];
        }

    }
}
