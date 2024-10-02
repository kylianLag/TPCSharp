namespace AP3V
{
    class Realisateur
    {
        private string nom;
        private string prenom;

        public Realisateur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;

        }


    }
}