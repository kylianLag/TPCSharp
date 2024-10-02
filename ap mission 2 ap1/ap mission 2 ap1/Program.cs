//Paramètre de classe sur la connexion
using MySql.Data.MySqlClient;
class Program
{
    private static MySqlConnection laConnexion;
    public static void Main(string[] args)
    {
        string maChaineConnexion = "";
        {
            maChaineConnexion = "server=localhost;database=ap1;port=3306;uid=admin;pwd=admin";
        }

        laConnexion = new MySqlConnection();
        laConnexion.ConnectionString = maChaineConnexion;
        laConnexion.Open();
        string maRequete = "";
        Console.WriteLine("Veuillez choisir un centre (1-4)");
        string[] tab = new string[4];
        tab[0] = "LoisiCentre";
        tab[1] = "Educentre";
        tab[2] = "Megacentre";
        tab[3] = "multicentre";
      for(int i =0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i] + " (" +(i+1) + ")");
        }

        int choix = System.Convert.ToInt32(Console.ReadLine());
        if (choix == 1)
        {
            maRequete = "SELECT * FROM CENTRE WHERE IdCentre = 1";
        }
        else if (choix == 2)
        {
            maRequete = "SELECT * FROM CENTRE WHERE IdCentre = 2";
        }
        else if (choix == 3)
        {
            maRequete = "SELECT * FROM CENTRE WHERE IdCentre = 3";
        }
        else if (choix ==4)
        {
            maRequete = "SELECT * FROM CENTRE WHERE IdCentre = 6";
        }
        else
        {
            Console.WriteLine("votre centre n'existe pas !");
        }


        MySqlCommand maCommande;
        MySqlCommand maCommande2;
        MySqlDataReader mesResultats;
        MySqlConnection conn;
        maCommande = new MySqlCommand(maRequete, laConnexion);
        mesResultats = maCommande.ExecuteReader();
        int idcentre = 0;
        
        while (mesResultats.Read())
        {
            Console.WriteLine("Le centre choisi est "+ mesResultats.GetString("nom") + "\n");
            idcentre = mesResultats.GetInt32("idcentre");
            
        }
        mesResultats.Close();
        MySqlDataReader mesResultats2;
        //Console.WriteLine(idcentre+"test");
        string maRequete2 = "SELECT specialite.nom from specialite join avoir on avoir.idspecialite = specialite.idspecialite join centre on avoir.idcentre = centre.idcentre where centre.idcentre=" + idcentre;
       // maRequete2 = "select * from specialite";
        maCommande2 = new MySqlCommand(maRequete2, laConnexion);
        mesResultats2 = maCommande2.ExecuteReader();
        string spe = "";
        Console.WriteLine("Les options disponible pour ce centre sont : \n");
        bool musique = false;
        bool danse = false;
        bool dessin = false;
        
        while (mesResultats2.Read())
        {
            if (mesResultats2.GetString("nom") == "musique")
            {
                Console.WriteLine(mesResultats2.GetString("nom") + " (1)");
                musique = true;
            }else if (mesResultats2.GetString("nom") == "danse")
            {
                Console.WriteLine(mesResultats2.GetString("nom") + " (2)");
                danse = true;

            }else if (mesResultats2.GetString("nom") == "dessin")
                {
                    Console.WriteLine(mesResultats2.GetString("nom") + " (3)");
                    dessin = true;
                }

            
           
            

        }


        string option1 = "";
        string option2 = "";
        string option3 = "";
        string maRequete3 = "";
        string maRequete4 = "";
        string maRequete5 = "";
        int choixspe = 0;
        int count = 1;
        while(count == 1)
        {
            Console.WriteLine("\nveuillez saisir uniquement une option disponible ci dessus ! \nsi plusieur options veuillez saisir les numeros cote a cote par exemple: : 13 ou 231 etc... ");
             choixspe = Convert.ToInt32(Console.ReadLine());
            switch (choixspe)
            {

                case 1:
                    if(musique == true)
                    {
                        option1 = "musique";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"musique\" and centre.IdCentre =" + idcentre;
                        count = 0;
                        
                    }
                    break;
                    

                case 2:

                    if(danse == true)
                    {
                        option2 = "danse";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"danse\" and centre.IdCentre =" + idcentre;
                        count = 0;
                        
                    }
                    break;
                    
                   

                case 3:
                    if(dessin == true)
                    {
                        option3 = "dessin";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"dessin\" and centre.IdCentre =" + idcentre;
                        count = 0;
                        
                    }
                    
                        break;
                    

                case 12 or 21:
                    if(musique == true && danse == true)
                    {
                        option1 = "musique";
                        option2 = "danse";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"musique\" and centre.IdCentre =" + idcentre;
                        maRequete4 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"danse\" and centre.IdCentre =" + idcentre;
                        count = 2;
                        
                    }
                    break;
                    

                case 13 or 31:
                    if(musique == true && dessin == true)
                    {
                        option1 = " musique";
                        option3 = " dessin";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"musique\" and centre.IdCentre =" + idcentre;
                        maRequete4 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"dessin\" and centre.IdCentre =" + idcentre;
                        count = 2;
                    }
                    
                    break;

                case 23 or 32:
                    if (danse == true && dessin == true)
                    {
                        option2 = "danse";
                        option3 = "dessin";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"dessin\" and centre.IdCentre =" + idcentre;
                        maRequete4 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"danse\" and centre.IdCentre =" + idcentre;
                        count = 2;
                    }
                    
                    break;

                case 123 or 132 or 231 or 213 or 312 or 321:
                    if(musique == true && danse == true && dessin == true)
                    {
                        option1 = "musique";
                        option2 = "danse";
                        option3 = "dessin";
                        maRequete3 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"musique\" and centre.IdCentre =" + idcentre;
                        maRequete4 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"danse\" and centre.IdCentre =" + idcentre;
                        maRequete5 = "SELECT tarifs.prix FROM tarifs join specialite on tarifs.id_spe = specialite.IdSpecialite join centre on tarifs.id_centre = centre.IdCentre where specialite.nom = \"dessin\" and centre.IdCentre =" + idcentre;
                        count = 3;
                    }
                    
                    break;

                default:
                    Console.WriteLine("Votre combinaisons n'est pas valide.");
                    count = 1;
                    break;
            }
       

        }
        
        Console.WriteLine("Vous avez bien choisis l'option" + " " + option1 + " " + option2 + " " + option3);
        mesResultats2.Close();
        MySqlDataReader mesResultats3;
        MySqlDataReader mesResultats4;
        MySqlDataReader mesResultats5;
        MySqlDataReader mesResultats6;
        MySqlCommand maCommande3;
        MySqlCommand maCommande4;
        MySqlCommand maCommande5;
        MySqlCommand maCommande6;

        float somme = 0;
        
        if (maRequete3 != "")
        {
            maCommande3 = new MySqlCommand(maRequete3, laConnexion);
            mesResultats3 = maCommande3.ExecuteReader();

            while (mesResultats3.Read())
            {

               // Console.WriteLine(mesResultats3.GetFloat("prix"));
                somme=somme+  mesResultats3.GetFloat("prix");



            }
            mesResultats3.Close();
        }
        


        if(maRequete4 != "")
        {
            maCommande4 = new MySqlCommand(maRequete4, laConnexion);
            mesResultats4 = maCommande4.ExecuteReader();

            while (mesResultats4.Read())
            {

                //Console.WriteLine(mesResultats4.GetFloat("prix"));
                somme=somme+  mesResultats4.GetFloat("prix");


            }
            mesResultats4.Close();
        }


        if (maRequete5 != "")
        {
            maCommande5 = new MySqlCommand(maRequete5, laConnexion);
            mesResultats5 = maCommande5.ExecuteReader();

            while (mesResultats5.Read())
            {

               // Console.WriteLine(mesResultats5.GetFloat("prix"));
                somme=somme+ mesResultats5.GetFloat("prix");


            }
            mesResultats5.Close();
        }

        Console.WriteLine("Sans reduction vous devez payer un total de : "+somme);
        float remise = 0;

       
        
       string  maRequete6 = "SELECT remise2 FROM remise join centre on remise.idcentre = centre.idcentre where remise.idCentre =" + idcentre;


        if (count == 2 )
        {
            maCommande6 = new MySqlCommand(maRequete6, laConnexion);
            mesResultats6 = maCommande6.ExecuteReader();

            while (mesResultats6.Read())
            {

               // Console.WriteLine(mesResultats6.GetFloat("remise2"));
                remise = mesResultats6.GetFloat("remise2");


            }
            mesResultats6.Close();
        }else if(count == 3)
        {
            maCommande6 = new MySqlCommand(maRequete6, laConnexion);
            mesResultats6 = maCommande6.ExecuteReader();

            while (mesResultats6.Read())
            {

                Console.WriteLine(mesResultats6.GetFloat("remise3"));
                remise = mesResultats6.GetFloat("remise3");


            }
            mesResultats6.Close();
        }
        if(count == 0)
        {
            Console.WriteLine("vous ne beneficier pas de reduction");
        }
        else
        {
            Console.WriteLine("en appliquant votre reduction , vous devez payé " + (somme * remise));
        }

        Console.WriteLine("veuillez saisir quelque chose afin de terminer le programme");
        Console.ReadLine();
    }
   
}

