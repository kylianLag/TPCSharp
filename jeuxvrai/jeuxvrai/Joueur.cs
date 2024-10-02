using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxvrai
{
    class Joueur
    {
        private string nom;
        private int niveauVie;
        private int niveauAttaque;
        private int vieMax;
        private zone zone;
        private List<monstre> ListeMonstreVaincue;


        public Joueur(string nom, int vie, int attaque, int vieMax, zone zone)
        {
            this.nom = nom;
            this.niveauVie = vie;
            this.niveauAttaque = attaque;
            this.vieMax = vieMax;
            this.zone = zone;
            ListeMonstreVaincue = new List<monstre>();
            
        }   

      public string getNom()
        {
            return this.nom;
        }
        public zone getZone()
        {
            return this.zone;
        }
        public int getVieMax()
        {
            return this.vieMax;
        }

        public int getVie()
        {
            return this.niveauVie;
        }

        public int getAttaque()
        {
            return this.niveauAttaque;
        }

       

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setVie(int vie)
        {
            this.niveauVie = vie;
        }

        public void setZone(zone zone)
        {
            this.zone = zone;
        }

        public void setAttaque(int attaque)
        {
            this.niveauAttaque = attaque;
        }
        public void setVieMax(int vieMax)
        {
            this.vieMax=vieMax;
        }

        public void sesoigner()
        {
           if(this.niveauVie + (this.vieMax / 2) >= this.vieMax)
            {
                this.niveauVie = vieMax;
            }
            else
            {
                this.niveauVie = this.niveauVie + (this.vieMax / 2);
            }
        }
        public void subirDegat(int degat)
        {
            this.niveauVie = this.niveauVie - degat;
        }
        

        public bool fuir()
        {
            Random aleatoire = new Random();
            int t = aleatoire.Next(100);
            if (t <= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public void attaquerMonstre(monstre monstre)
        {
            monstre.subirDegat(this.niveauAttaque);
            if(monstre.getVie() < 0)
            {
                monstre.setVie(0);
            }
            if (monstre.estVaincu())
            {
                this.ListeMonstreVaincue.Add(monstre);
            }
        }
        public void afficherMonstreTuer()
        {
            Console.WriteLine("Vous avez tuer : \n");
            foreach (monstre t in ListeMonstreVaincue)
            {
                Console.WriteLine(t);

            }
        }

        public override string ToString()
        {
            return "[nom] : " + this.nom + " [VieMax] : " + this.vieMax + " [Vie Actuelle] : " + this.niveauVie + " [attaque]: " + this.niveauAttaque + " [Zone] : " + this.zone;
        }


    }
}
