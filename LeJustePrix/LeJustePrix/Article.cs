using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeJustePrix
{
    public class Article
    {
        private string nom;
        private string desc;
        private int prix;

        public Article(string nom,string desc,int prix)
        {
            this.nom = nom;
            this.desc = desc;
            this.prix = prix;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getDesc()
        {
            return this.desc;
        }

        public int getPrix()
        {
            return this.prix;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setDesc(string desc)
        {
            this.desc = desc;
        }

        public void setPrix(int prix)
        {
            this.prix = prix;
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + " desc : " + this.desc+"\n";
        }
    }
}
