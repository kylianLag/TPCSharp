class Program
{

    public static void Main(String[] args)
    {
        /* int[] tabCode; //déclaration de la variable

tabCode = new int[5]; //instanciation

tabCode[0] = 1250; 
tabCode[1] = 2507;
tabCode[2] = 5808;
tabCode[3] = 8700;
tabCode[4] = 5080;

Console.WriteLine("Veuillez saisir un code pin : ");
int CodePin = Convert.ToInt32(Console.ReadLine());
bool trouver = false;

foreach(int i in tabCode)
{
    if(i == CodePin)
    {
        trouver = true;
    }
}

if (trouver == true)
{
    Console.WriteLine("Code PIN validé.");
}
else
{
    Console.WriteLine("Code PIN invalide");
}*/




        //tableau preconstruit
        //string[] tabFruit = { "pomme", "poire", "banane" };//


        //Console.WriteLine(tabFruit);// //affichage de la structure mais pas du contenu


        //parcourir le tableau

        //for 

        /* for(int i = 0; i < tabFruit.Length; i++)
        {
            Console.WriteLine(tabFruit[i]);
        }
        */


        //foreach

        /* foreach (string s in tabFruit)
        {
            Console.WriteLine(s);
        }
        */
        /*
        string[] tabjour = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

        Console.WriteLine(tabjour[2]);
        //mettre à jour le 3éme jour et mettre férié a la place.

        tabjour[1] = "férié";

        foreach(string jour in tabjour)
        {
            Console.WriteLine(jour);
        }
        */

        //tableau 2D
        


        
        int[,] tableau2D = new int[5, 2];
        tableau2D[0, 0] = 15;
        tableau2D[0, 1] = 2;
        tableau2D[1, 0] = 7;
        tableau2D[1, 1] = 1;
       
        // moyenne ?? 
        // parcours

        double moyenne = 0;
        int sommeCoef = 0;
        /* for (int i = 0; i < 2; i++)
         {
             int note = tableau2D[i, 0];
             int coef = tableau2D[i, 1];
             sommeCoef += coef;
             moyenne += note * coef;
         }
         moyenne = moyenne / sommeCoef;
         Console.WriteLine("moyenne : " + moyenne);

         */
        //2boucles possible:
        foreach (int a in tableau2D)
        {
            Console.WriteLine(a);
        }

        //facile a use mais on connait pas la pos exacte



        //2 for imbriqué:
        //permet de maitriser la position exact des val
        /*
        for (int i =0; i<tableau2D.GetLength(0); i++)//ligne
        {
            int note = tableau2D[i, 0];
            int coef = tableau2D[i, 1];
            sommeCoef = sommeCoef + coef;
            moyenne = moyenne + note * coef;
            for (int j = 0; j < tableau2D.GetLength(1); j++)//colonne
            {
                Console.WriteLine((tableau2D[i,j]));
            }

            
        }
        moyenne = moyenne / sommeCoef;
            Console.WriteLine(moyenne);
        */
    }
}



