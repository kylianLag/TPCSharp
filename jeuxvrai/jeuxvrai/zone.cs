using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxvrai
{
    class zone
    {
        private string nom;
        private int difficulte;
        public List<monstre> ListeMonstres;

        public zone(string nom, int difficulte)
        {
            this.nom = nom;
            ListeMonstres = new List<monstre>();
            this.difficulte = difficulte;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public int getDifficulte()
        {
            return this.difficulte;
        }

        public void setDifficulte(int d)
        {
            this.difficulte = d;
        }

        public void ajouterMonstre(monstre monstre)
        {
            if(monstre.getniveauDifficulter() <= this.getDifficulte())
            {
                ListeMonstres.Add(monstre);
            }
            else
            {
                Console.WriteLine("le monstre est trop fort pour cette zone");
            }
            
        }

        public void retirerMonstre(monstre monstre)
        {
            ListeMonstres.Remove(monstre);
        }
        public override string ToString()
        {
            return " [Nom] : " + this.nom + " [Niveau de difficulté Max rencontrable ]:" + this.difficulte;
        }
        public int nbmonstre()
        {
           int Count = 0;
            foreach(monstre monstre in ListeMonstres)
            {
               
                    Count++;
                
                
                
            }
            return Count;
        }

        

        public monstre choixMonstreIndice(int a)
        {
           
                return ListeMonstres[a];
            
            
        }

    }
}
