using entrainement_classe;

namespace entrainement_classe
{
    class Personnage
    {
        private string nom;
        private string prenom;
        private int age;
        private string sexe;
        private string origine;
        private List<Equipement> lesEquipements;

        public Personnage(string nom, string prenom, int age, string sexe, string origine)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.sexe = sexe;
            this.origine = origine;
            lesEquipements = new List<Equipement>();

        }

        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }

        public int getAge()
        {
            return this.age;
        }
        public string getSexe()
        {
            return this.sexe;
        }
        public string getOrigine()
        {
            return this.origine;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setSexe(string sexe)
        {
            this.sexe = sexe;
        }
        public void setOrigine(string origine)
        {
            this.origine = origine;
        }


        public bool estEquipe()
        {
            bool rtrEquipe = false;
            if (this.lesEquipements.Count > 0)
            {
                rtrEquipe = true;
            }
            return rtrEquipe;
        }

        public void AjoutEquipement(Equipement unEquipement)
        {
            this.lesEquipements.Add(unEquipement);
            
        }
        public double GetScoreEquipement()
        {
            double rtrScoreTotal = 0;
            foreach (Equipement unEquipement in this.lesEquipements)
            {
                //rtrScoreTotal = rtrScoreTotal + unEquipement.getScore()
                rtrScoreTotal += unEquipement.getScore();
            }
            return rtrScoreTotal;
        }

        public string GetLesEquipement()
        {
            string res = "\n \n";
            foreach(Equipement t in this.lesEquipements)
            {
                res =res+ ""+t.getNom() + " " + t.getType() + " avec un score de  " + t.getScore()+ "\n";
            }
            return "vous etes actuellement équipée avec : " + res;
            
        }


       public void ModifieEquipement(int score , int id)
        {
            foreach(Equipement t in this.lesEquipements)
            {
                if (t.getId() == id)
                {
                    t.setScore(score);
                }
            }
        }

        public override string ToString()
        {
            return "\n[nom] : " + this.nom + "\n[prenom] : " + this.prenom + "\n[age] : " + this.age + "\n[sexe] : " + this.sexe + "\n[origine] : " + this.origine;
        }


    }
}
