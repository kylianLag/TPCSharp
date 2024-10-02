using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrainement_classe
{
     class program
    {
        public static void Main(string[] args)
        {
            Equipement equipement1 = new Equipement(1, "casque", "commun", 100);
            Equipement equipement2 = new Equipement(2, "plastron", "rare", 3500);
            Personnage perso1 = new Personnage("lagache", "kylian", 20, "homme", "france");
            if (perso1.estEquipe())
            {
                Console.WriteLine("le personnage est équipé");
            }
            else
            {
                Console.WriteLine("le personnage n'est pas équipé");
            }
            Console.WriteLine(equipement1.ToString());
            Console.WriteLine(perso1.ToString() + "\n");
            perso1.AjoutEquipement(equipement1);
            perso1.AjoutEquipement(equipement2);
            Console.WriteLine(perso1.GetLesEquipement());
            perso1.ModifieEquipement(20, 1);
            Console.WriteLine("aprés modification du score , le nouveau score est de "+equipement1.getScore());
            Console.WriteLine("le score total est de  " + perso1.GetScoreEquipement());
            if (perso1.estEquipe())
            {
                Console.WriteLine("\nle personnage est équipé");
            }
            else
            {
                Console.WriteLine("\nle personnage n'est pas équipé");
            }

        }
    }
}
