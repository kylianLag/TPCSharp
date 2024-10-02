using System.Collections;
using System;
class Program
{
    public static void Main(String[] args)
    {
        //1) declaration de collection /Initialisation
        List<int> notes;
        //2) instanciation:
        notes = new List<int>();
        notes.Add(15);
        notes.Add(20);
        notes.Add(5);
        notes.Add(6);
        Console.WriteLine("le nombre de notes est de " + notes.Count() + "\n");
       double moy=  notes.Average();
        Console.WriteLine("la moyenne est de " + moy + "\n");
        //pas bon affichage :
        // Console.WriteLine(notes.ToString());

        //bonne affichage:
        afficherlist(notes);

        //exemple
        /*
        Console.WriteLine("saisir une note ");
        int saisie = Convert.ToInt32(Console.ReadLine());
        if (notes.Contains(saisie))
        {
            Console.WriteLine("note trouvé");
        }
        */

        Console.WriteLine("saisir une note a incrementer de 1");
        int saisie2 = Convert.ToInt32(Console.ReadLine());
        
        incrementeval(notes, saisie2);
        notes.Sort();
        afficherlist(notes);

        //araylist
        /* ArrayList jour = new ArrayList();
         jour.Add("Lundi");
         jour.Add("Mardi");
         jour.Add("Mercredi");
         jour.Add("Jeudi");
         jour.Add("Vendredi");
         jour.Add("Samedi");
         jour.Add("Dimanche");
        */
        //sortedlist
        SortedList température = new SortedList();
        température.Add(15, 4);
        température.Add(10, 0);

        //dictionnary:

        Dictionary<string, int> meteo = new Dictionary<string, int>();
        meteo.Add("lundi", 4);







    }

    public static void incrementeval(List<int>listnote , int note)
    {
        //on va chercher dans la liste si elle contient la note presente 
        //pour cette note la on veux l'incrementer de 1

        if (listnote.Contains(note))
        {
            listnote.Remove(note);
            listnote.Add(note + 1) ;
        }


    }

   public static void afficherlist(List<int> liste)
    {
        foreach (int i in liste)
        {
            Console.WriteLine(i);
        }
    }
}
