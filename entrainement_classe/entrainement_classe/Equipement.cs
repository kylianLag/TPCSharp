using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrainement_classe
{
    class Equipement
    {
       private int id;
       private string nom;
       private string type;
       private int score;

        public Equipement(int id, string nom, string type , int score)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.score = score;
        }

        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }

        public string getType()
        {
            return this.type;
        }
        public int getScore()
        {
            return this.score;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setScore(int score)
        {
            this.score = score;
        }

        public override string ToString()
        {
            return "\n[id] : " + this.id + "\n[nom] : " + this.nom + "\n[type] : " + this.type + "\n[score] : " + this.score;
        }

    }
}
