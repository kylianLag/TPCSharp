
namespace vraijeux
{
    class Program
    {
        
    
        public static void Main(string[] args)
        {

            zone debut = new zone("debut" , 0);
            Joueur joueur1 = new Joueur("kylian", 50, 20, 50, debut);
            zone plaine = new zone("plaine" , 5);
            zone montagne = new zone("montagne" , 6);
            jeu jeux = new jeu(joueur1);
            jeux.ajouterZone(plaine);
            jeux.ajouterZone(montagne);
            
             monstre slime = new monstre("slime", 10, 1, 10, plaine , 1);
             monstre gobelin = new monstre("gobelin", 20, 2, 20, plaine , 2);
             monstre troll = new monstre("troll", 40, 5, 40, montagne , 3);
             monstre RoiGobelin = new monstre("RoiGobelin", 70, 8, 70, plaine , 4);
             monstre Pilleur = new monstre("Pilleur", 70, 10, 70, montagne , 3);
             monstre ChienSauvage = new monstre("ChienSauvage", 30, 7, 30, plaine, 4);
             monstre CrapaudFrauduleux = new monstre("CrapaudFrauduleux", 100, 12, 100, montagne , 5);
             monstre bebeDragon = new monstre("bebeDragon", 90, 11, 90, plaine ,5);
            monstre Licorne = new monstre("Licorne", 85, 10, 85, plaine,5);
               monstre Dragon = new monstre("Dragon", 150, 15, 150, montagne, 6);
            plaine.ajouterMonstre(slime);
            plaine.ajouterMonstre(gobelin);
            plaine.ajouterMonstre(RoiGobelin);
            plaine.ajouterMonstre(ChienSauvage);
            plaine.ajouterMonstre(bebeDragon);
            plaine.ajouterMonstre(Licorne);

            montagne.ajouterMonstre(Dragon);
            montagne.ajouterMonstre(troll);
            montagne.ajouterMonstre(Pilleur);
            montagne.ajouterMonstre(CrapaudFrauduleux);



            Console.WriteLine("\n Vous venez de debuter , vous etes actuellement dans la zone depart\nles statistique de votre personnage sont : \n"+joueur1.ToString());
            
            Console.WriteLine("\n Vous avez le choix entre plusieurs zone , veuillez choisir votre zone parmis les zones disponible :\n");
            jeux.afficherZone();
            string choixZone = Console.ReadLine();
            if(choixZone == "plaine")
            {
                jeux.changerZone(plaine);
            }
            else
            {
                jeux.changerZone(montagne);
            }

            while(joueur1.getVie() > 0)
            {
                jeux.rencontreAleatoire();
                if(joueur1.getVie() > 0)
                {
                    Console.WriteLine("\naprés votre combat , vous vous enfoncer toujours plus loin dans les " + choixZone);
                }
                
            }
            
            
            

        }
    }

    
}