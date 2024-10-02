
namespace jeux_tp_note
{
    class Program
    {
        
    
        public static void Main(string[] args)
        {
            
            zone debut = new zone("depart");
            Joueur joueur1 = new Joueur("kylian", 20, 10, 20, debut);
            zone plaine = new zone("plaine");
            zone montagne = new zone("montagne");
           /* monstre slime = new monstre("slime", 3, 1, 3, debut);
            monstre gobelin = new monstre("gobelin", 3, 1, 3, plaine);
            monstre troll = new monstre("troll", 3, 1, 3, montagne);
            monstre RoiGobelin = new monstre("RoiGobelin", 3, 1, 3, plaine);
            monstre Pilleur = new monstre("Pilleur", 3, 1, 3, montagne);
            monstre ChienSauvage = new monstre("ChienSauvage", 3, 1, 3, plaine);
            monstre CrapaudFrauduleux = new monstre("CrapaudFrauduleux", 3, 1, 3, montagne);
            monstre bebeDragon = new monstre("bebeDragon", 3, 1, 3, plaine);
           *///monstre Licorne = new monstre("Licorne", 3, 1, 3, montagne);
            // monstre Dragon = new monstre("Dragon", 3, 1, 3, plaine);
            Console.WriteLine("Vous venez de debuter , vous etes actuellement dans la zone depart\nles statistique de votre personne sont : \n"+joueur1.ToString());
            Console.WriteLine("OMG vous tomber sur un slime ! combattez le !");
            //Console.WriteLine("\n"+slime.ToString());
            while (joueur1.getVie() > 0 )
            {
                joueur1.fuir();
                
            }
            

        }
    }

    
}