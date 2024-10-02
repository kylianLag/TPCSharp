using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_objet
{
    public class voiture
    {
        //ensemble attribut

        private string modele;
        private string marque;
        private string couleur;
        private string motorisation;
        private double volumeCoffre;
        private bool estDemarrer;
        public double capaciteMaxCarburant { get; set; }


        //constructeur : meme nom avec aucun type de retour 

        public voiture(string modele, string marque, string couleur, string motorisation, double volumeCoffre, double capaciteMaxCarburant)
        {
            this.modele = modele;
            this.marque = marque;
            this.couleur = couleur;
            this.motorisation = motorisation;
            this.volumeCoffre = volumeCoffre;
            this.estDemarrer = false;
            this.capaciteMaxCarburant = capaciteMaxCarburant;
        }

        //tostring() affichage

        public override string ToString()
        {
            return "\nvoiture:\n[Marque]: " + this.marque + "\n[Modele]: " + this.modele + " \n[Couleur]: " + this.couleur + " \n[Motorisation]: " + this.motorisation + " \n[Volume]: " + this.volumeCoffre + "\n[estDemmarer]: " + this.estDemarrer + "\n" + "\n[CapaciteMaxCarburant]: " + this.capaciteMaxCarburant + "\n";
        }

        //ensemble methode

        //ensemble accesseur : get , set !

        public string getModele()
        {
            return this.modele;
        }

        public bool getEstDemmarer()
        {
            return this.estDemarrer;
        }

        public void setEstDemmarer(bool estDemmarer)
        {
            this.estDemarrer = estDemmarer;
        }

        public void setModele(string modele)
        {
            this.modele = modele;
        }

        public string getMarque()
        {
            return this.marque;
        }

        public void setMarque(string marque)
        {
            this.marque = marque;
        }

        public string getCouleur()
        {
            return this.couleur;
        }

        public void setCouleur(string couleur)
        {
            this.couleur = couleur;
        }

        public string getMotorisation()
        {
            return this.motorisation;
        }

        public void setMotorisation(string motorisation)
        {
            this.motorisation = motorisation;
        }

        public double getVolumeCoffre()
        {
            return this.volumeCoffre;
        }

        public void setVolume(double volumeCoffre)
        {
            this.volumeCoffre = volumeCoffre;
        }

        public bool remplirCoffre(double volume)
        {
            //on eut ajt un volume a la voiture
            //on s'assure que le parametre est plus petit que le volume du coffre
            //on va reduire le volume coffre par rapport au volume passé
            //si tout ok on return vrai sinon faux
            if (this.volumeCoffre > volume)
            {
                this.volumeCoffre = this.volumeCoffre - volume;
                return true;
            }
            return false;

        }


        public void Demmarrer()
        {
            if (this.estDemarrer != true)
            {
                this.estDemarrer = true;
            }

        }

        //methode 3:faire le plein
        //2 parametre (niveau actuel de carburant , type de carburant)

        //verifier type de carburant
        //maj de la capacité max du carbu > capacité max
        //electrique = 1l/min
        //diesel=1l/30sec
        //la mathode nous retourne le temps pour faire le plein

        public double faireLePlein(double volume, string type)
        {
            int coeff = 1;
            double remplir = 0;
            double time = 0;
            if (type == this.motorisation && volume < this.capaciteMaxCarburant)
            {
                remplir = this.capaciteMaxCarburant - volume;
                while (remplir != 0)
                {
                    remplir = remplir - coeff;
                    if (this.motorisation == "electrique")
                    {
                        time = time + 1;
                    }
                    else if (this.motorisation == "diesel")
                    {
                        time = time + 0.5;
                    }
                }


            }
            return time;
        }

        //methode prof
            

       /* public double plein(double volume , string type)
        {
            if (volume < this.capaciteMaxCarburant)
            {
                if(type == this.motorisation)
                {
                    double volplein = this.capaciteMaxCarburant - volume;
                    double tempspleint = 0;
                    if(type == "diesel")
                    {
                        tempspleint = volplein * 30;
                    }else if(type == "electrique")
                    {
                        tempspleint = volplein * 60;
                    }
                    return tempspleint;
                }
                else
                {
                    Console.WriteLine("carburant invalide");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("volume trop grand");
                return -1;
            }
        }
        
        */






    }
}
