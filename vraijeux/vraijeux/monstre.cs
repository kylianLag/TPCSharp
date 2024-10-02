using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraijeux
{
    class monstre
    {
        private string nom;
        private int niveauVie;
        private int niveauAttaque;
        private int vieMax;
        private int niveauDifficulter;
        private zone zone;

        public monstre(string nom, int niveauVie, int niveauAttaque , int vieMax , zone zone , int niveauDifficulter)
        {
            this.nom = nom;
            this.niveauVie = niveauVie;
            this.niveauAttaque = niveauAttaque;
            this.vieMax = vieMax;
            this.zone = zone;
            this.niveauDifficulter = niveauDifficulter;


        }



        public string getNom()
        {
            return this.nom;
        }
        public int getVieMax()
        {
            return this.vieMax;
        }
        public zone getZone()
        {
            return this.zone;
        }
        public int getVie()
        {
            return this.niveauVie;
        }
        public int getniveauDifficulter()
        {
            return this.niveauDifficulter;
        }

        public int getAttaque()
        {
            return this.niveauAttaque;
        }

        public void setniveauDifficulter(int niveauDifficulter)
        {
            this.niveauDifficulter = niveauDifficulter;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setVieMax(int vieMax)
        {
            this.vieMax = vieMax;
        }
        public void setZone(zone zone)
        {
            this.zone = zone;
        }

        public void setVie(int vie)
        {
            this.niveauVie = vie;
        }

        public void setAttaque(int attaque)
        {
            this.niveauAttaque = attaque;
        }



        public bool estVaincu()
        {
            if (this.niveauVie <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public void subirDegat(int degat)
            {
                this.niveauVie = this.niveauVie - degat;
            }
        public void attaquerJoueur(Joueur joueur)
        {
            joueur.subirDegat(this.niveauAttaque);
            if (joueur.getVie() < 0)
            {
                joueur.setVie(0);
            }
            
        }

        public override string ToString()
        {
            return "[nom] : " + this.nom + " [VieMax] : " + this.vieMax + " [Vie Actuelle] : " + this.niveauVie + " [attaque]: " + this.niveauAttaque + " [Zone] : " + this.zone+"[Niveau de difficulter] :"+this.niveauDifficulter;
        }

    }
}
