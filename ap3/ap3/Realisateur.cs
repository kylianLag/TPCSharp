namespace AP3
{
    public class Realisateur
    {
        private string nom;
        private string prenom;
        public List<Film> Films { get; private set; }

        public Realisateur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Films = new List<Film>();
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

        public void AjouterFilm(Film film)
        {
            Films.Add(film);
        }

        public override string ToString()
        {
            return "prenom : " + this.prenom + "\n nom : " + this.nom;
        }

        public void supprimerFilm(Film film)
        {

            Films.Remove(film);
        }
    }
}