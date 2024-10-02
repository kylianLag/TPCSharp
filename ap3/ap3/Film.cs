using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.IO;
using static System.Net.WebRequestMethods;

namespace AP3
{
    public class Film
    {
        //nom de film
        //nom_section
        //nom_prix
        //int année 

        private string Nom_film;
        private string Nom_section;
        private string Nom_prix;
        private string Annee;
        public Realisateur Realisateur;


        public Film(string Nom_film, string Nom_section, string Nom_prix, string Annee, Realisateur realisateur)
        {
            this.Nom_film = Nom_film;
            this.Nom_section = Nom_section;
            this.Nom_prix = Nom_prix;
            this.Annee = Annee;
            this.Realisateur = realisateur;
        }

        public override string ToString()
        {
            return "Nom du film : " + this.Nom_film + "\n" + "Nom de la section : " + this.Nom_section + "\n" + "Nom du prix : " + this.Nom_prix + "\n" + "annee : " + this.Annee+"\n Realisateur"+ this.Realisateur;
        }



        public string GetNom_film()
        {
            return this.Nom_film;
        }
        public void SetNom_film(string Nom_film)
        {
            this.Nom_film = Nom_film;
        }

        public Realisateur GetRea_film()
        {
            return this.Realisateur;
        }
        public void SetRea_film(Realisateur rea)
        {
            this.Realisateur = rea;
        }
        public string GetNom_section()
        {
            return this.Nom_section;
        }
        public void SetNom_section(string Nom_section)
        {
            this.Nom_section = Nom_section;
        }
        public string GetNom_prix()
        {
            return this.Nom_prix;
        }
        public void SetNom_prix(string Nom_prix)
        {
            this.Nom_prix = Nom_prix;
        }
        public string GetAnnee()
        {
            return this.Annee;
        }
        public void SetAnnee(string annee)
        {
            this.Annee = annee;
        }

        public void ModifierFilm(string titre, string section, string prix, string annee)
        {
            this.Nom_film = titre;
            this.Nom_section = section;
            Nom_prix = prix;
            this.Annee = annee;
        }

        

    }
}