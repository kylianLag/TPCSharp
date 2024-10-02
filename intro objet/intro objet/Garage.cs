using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_objet
{
    public class Garage
    {
        //attribut de base:
        public string nom;
        public string addresse;
        //attribut de liaison
        //le gare possede 1  ou plusieur voiture (1..*)
        List<voiture> lesVoitures;
        

        public Garage(string nom , string addresse)
        {
            this.nom = nom;
            this.addresse = addresse;
            //faut gerer l'attribut de liaison , on ne veux plus de list null mais une liste vide
            lesVoitures = new List<voiture>();
        }
        
        public string getNom()
        {
            return this.nom;
        }

        public string getAddresse()
        {
            return this.addresse;
        }


        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setAddresse(string addresse)
        {
            this.addresse = addresse;
        }

        //ajoutez voiture
        public void ajouterVoiture(voiture voiture)
        {
            this.lesVoitures.Add(voiture);
        }

        public override string ToString()
        {
            string str = "{Garage}:\n[nom] : " + this.nom + "\n[addresse] : " + this.addresse + "\n";
            foreach(voiture v in lesVoitures)
            {
                str += v.ToString();
            }
            return str;
        }

        /*liste des méthode:
         * supprimervoiture : on met une voiture en parametre et on s'assure qu'elle existe , si elle existe on la supprimer de la list
         * 
         * remplacerVoiture : si la liste contient la voiture passer en parametre et on veut la remplacer par la 2e voiture en parametre
         * 
         * capaciteTotaleVoiture: on parcour la list des voiture et on recup pour chaque voiture la capacité du coffre de la voiture pour l'ajouter au total et return total
         * 
         * listeCouleurVoiture : on parour la liste des voitures et pour chaque voiture on recup la couleur de la voiture et on va compter le nombre de fois qu'on trouve la couleur
         * */

        public bool supprimerVoiture(voiture voiture)
        {
            
                if(this.lesVoitures.Contains(voiture))
                {
                    this.lesVoitures.Remove(voiture);
                return true;
                }
            return false;
        }

        public void remplacerVoiture(voiture a, voiture b)
        {
            if (supprimerVoiture(a))
            {
                ajouterVoiture(b);
            }
          
        }

        public double capaciteTotalVoiture()
        {
            double total = 0;
            foreach (voiture v in this.lesVoitures)
            {
                total = total + v.getVolumeCoffre();
            }
            return total;
        }

        public Dictionary<string , int> nombreTotalcouleur()
        {
            Dictionary<string,int> dico = new Dictionary<string,int>();
            int count = 0;
            foreach (voiture v in this.lesVoitures)
            {
                string couleur = v.getCouleur();
                if (dico.ContainsKey(couleur))
                {
                    dico[couleur]++;
                }
                else
                {
                    dico.Add(couleur, 1);
                }
                   
            }
            return dico;
            
        }

        


        
    }

    
}
