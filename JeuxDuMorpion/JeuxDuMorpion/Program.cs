class Program
{
    public static void Main(String[] args)
    {
       
        char[,] tab = new char[3,3];
        resettab(tab);
        afficherTab(tab);
        int count = 0;
        bool win = false;
        string choix1 = "";
        string choix2 = "";
        int conpteur_j1 = 0;
        int conpteur_j2 = 0;

        while (choix2 != "stop" || choix1 != "stop")
        {
            
           
            Console.WriteLine(count);
            Console.WriteLine("Veuillez choisir l'endroit ou poser votre signe , la synthaxe est LigneColonne (Vous etes le joueur X)");
            choix1 = Console.ReadLine();
            if (choix1 == "stop")
            {
                break;
            }
            else if (verif(tab, choix1))
            {
                change1(tab, choix1);
                count++;
               // Console.WriteLine(count);
            }
            else
            {
                afficherTab(tab);
                Console.WriteLine("Veuillez choisir un autre endroit ou poser votre signe , la synthaxe est LigneColonne (Vous etes le joueur X)");
                choix1 = Console.ReadLine();
                change1(tab, choix1);
                count++;
              //  Console.WriteLine(count);
            }
            if (count%9 ==0)
            {
                 Console.WriteLine("Match null , la partie va recommencer :");
                 resettab(tab);
                

            }


            if (victoire1(tab))
            {
                conpteur_j1++;
                Console.WriteLine("Le joueur X a gagner !!");
                Console.WriteLine("Le resultat est de " + conpteur_j1 + " pour le joueur 1 et " + conpteur_j2 + "pour le joueur 2");
                win = true;
                resettab(tab);
                afficherTab(tab);
                count = 0;

            }
            Console.WriteLine("Veuillez choisir l'endroit ou poser votre signe , la synthaxe est LigneColonne (Vous etes le joueur 0)");
            choix2 = Console.ReadLine();
            if (choix2 == "stop")
            {
                break;
            }
            else if (verif(tab, choix2))
            {
                change2(tab, choix2);
                count++;
               // Console.WriteLine(count);
            }
            else
            {
                afficherTab(tab);
                Console.WriteLine("Veuillez choisir un autre endroit ou poser votre signe , la synthaxe est LigneColonne (Vous etes le joueur 0)");
                choix2 = Console.ReadLine();
                change2(tab, choix2);
                count++;
               // Console.WriteLine(count);
            }
            if (count == 9)
            {
                afficherTab(tab);
                 Console.WriteLine("Match null , la partie va recommencer :");
                 resettab(tab);
                count = 0;
                
                

            }


            if (victoire2(tab))
            {
                conpteur_j2++;
                Console.WriteLine("Le joueur 0 a gagner !!");
                Console.WriteLine("Le resultat est de "+ conpteur_j1 + "pour le joueur 1 et "+ conpteur_j2 + "pour le joueur 2");
                win = true;
                resettab(tab);
                afficherTab(tab);
                count = 0;

            }


        }

       
        
        

    }

    public static bool victoire1(char[,] tab)
    {
        if (tab[0, 0] == 'X' && tab[1, 0] == 'X' && tab[2, 0] == 'X')
        {
            return true;
        }
        //Marche

        else if (tab[0, 1] == 'X' && tab[1, 1] == 'X' && tab[2, 1] == 'X')
        {
            return true;

        }
        //marche

            
        else if (tab[0, 2] == 'X' && tab[1, 2] == 'X' && tab[2, 2] == 'X')
        {

            return true;
        }
        //marche
        else if (tab[0, 0] == 'X' && tab[0, 1] == 'X' && tab[0, 2] == 'X')
        {
            return true;
        }
        //marche

        else if (tab[1, 0] == 'X' && tab[1, 1] == 'X' && tab[1, 2] == 'X')
        {
            return true;
        }
        //marche

        else if (tab[2, 0] == 'X' && tab[2, 1] == 'X' && tab[2, 2] == 'X')
        {
            return true;
        }
        //marche

        else if (tab[0, 0] == 'X' && tab[1, 1] == 'X' && tab[2, 2] == 'X')
        {
            return true;
        }else if (tab[2, 0] == 'X' && tab[1, 1] == 'X' && tab[0, 2] == 'X')
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool victoire2(char[,] tab)
    {
        if (tab[0, 0] == '0' && tab[1, 0] == '0' && tab[2, 0] == '0')
        {
            return true;
        }
        //Marche

        else if (tab[0, 1] == '0' && tab[1, 1] == '0' && tab[2, 1] == '0')
        {
            return true;

        }
        //marche


        else if (tab[0, 2] == '0' && tab[1, 2] == '0' && tab[2, 2] == '0')
        {

            return true;
        }
        //marche
        else if (tab[0, 0] == '0' && tab[0, 1] == '0' && tab[0, 2] == '0')
        {
            return true;
        }
        //marche

        else if (tab[1, 0] == '0' && tab[1, 1] == '0' && tab[1, 2] == '0')
        {
            return true;
        }
        //marche

        else if (tab[2, 0] == '0' && tab[2, 1] == '0' && tab[2, 2] == '0')
        {
            return true;
        }
        //marche

        else if (tab[0, 0] == '0' && tab[1, 1] == '0' && tab[2, 2] == '0')
        {
            return true;
        }
        else if (tab[2, 0] == '0' && tab[1, 1] == '0' && tab[0, 2] == '0')
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static void afficherTab(char[,] tab)
    {
        Console.WriteLine(" ABC");
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            string chaine = "";

            for (int j = 0; j < tab.GetLength(1); j++)
            {
                chaine += tab[i, j];


            }

            Console.WriteLine(i + chaine);
        }

    }


    public static void change1(char[,] tab ,string choix1)
    {
        if (choix1 == "A0")
        {
            tab[0, 0] = 'X';
            afficherTab(tab);

        }
        else if (choix1 == "A1")
        {
            tab[1, 0] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "A2")
        {
            tab[2, 0] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "B0")
        {
            tab[0, 1] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "B1")
        {
            tab[1, 1] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "B2")
        {
            tab[2, 1] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "C0")
        {
            tab[0, 2] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "C1")
        {
            tab[1, 2] = 'X';
            afficherTab(tab);
        }
        else if (choix1 == "C2")
        {
            tab[2, 2] = 'X';
            afficherTab(tab);
        }
    }
    public static bool verif(char[,] tab , string choix1)
    {
        if (choix1 == "A0" && tab[0,0] == '.')
        {
            return true;

        }
        else if (choix1 == "A1" && tab[1, 0] == '.')
        {

            return true;
        }
        else if (choix1 == "A2" && tab[2, 0] == '.')
        {
            
            return true;
        }
        else if (choix1 == "B0" && tab[0, 1] == '.')
        {
            
            return true;
        }
        else if (choix1 == "B1" && tab[1, 1] == '.')
        {
            
            return true;
        }
        else if (choix1 == "B2" && tab[2, 1] == '.')
        {
           
            return true;
        }
        else if (choix1 == "C0" && tab[0, 2] == '.')
        {
            
            return true;
        }
        else if (choix1 == "C1" && tab[1, 2] == '.')
        {
            
            return true;
        }
        else if (choix1 == "C2" && tab[2, 2] == '.')
        {
            
            return true;
        }
        return false;
    }

    public static void resettab(char[,] tab)
    {
        tab[0, 0] = '.';
        tab[0, 1] = '.';
        tab[0, 2] = '.';

        tab[1, 0] = '.';
        tab[1, 1] = '.';
        tab[1, 2] = '.';

        tab[2, 0] = '.';
        tab[2, 1] = '.';
        tab[2, 2] = '.';
    }
    public static void change2(char[,] tab, string choix1)
    {
        if (choix1 == "A0")
        {
            tab[0, 0] = '0';
            afficherTab(tab);

        }
        else if (choix1 == "A1")
        {
            tab[1, 0] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "A2")
        {
            tab[2, 0] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "B0")
        {
            tab[0, 1] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "B1")
        {
            tab[1, 1] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "B2")
        {
            tab[2, 1] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "C0")
        {
            tab[0, 2] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "C1")
        {
            tab[1, 2] = '0';
            afficherTab(tab);
        }
        else if (choix1 == "C2")
        {
            tab[2, 2] = '0';
            afficherTab(tab);
        }
    }
}
