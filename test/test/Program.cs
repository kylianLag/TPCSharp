class Program
{

	public static void Main(String[] args)
	{
        //	Console.WriteLine("ligne 1 "); /*permet d'ecrire un message dans la console */


        //type natif

        /*
		int a;
		double b;
		string c;
		char d;
		bool e;
		null;
		*/

        //Exemple 1 avec chaine
        /*
		Console.WriteLine("Saisir le premier nombre");
		String lemot=console.ReadLine();
		console.WriteLine("votre mot est " + lemot);
		*/

        /*
			//Exemple 2

		Console.WriteLine("Veuillez saisir le premier nombre");
		int nb1=  Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Veuillez saisir le second nombre");
		int nb2=  Convert.ToInt32(Console.ReadLine());

		int res = nb1+nb2;
		Console.WriteLine("l'addition des deux nombre est de " + res);
		 
		*/

        //exemple 3 condition
        /*
		Console.WriteLine("Veuillez saisir le premier nombre");
		int nb1=  Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Veuillez saisir le second nombre");
		int nb2=  Convert.ToInt32(Console.ReadLine());

		if(nb1<nb2){
			Console.WriteLine("plus petit")
		}else if(nb1>nb2){
			Console.WriteLine("plus grand")
		}else{
			Console.WriteLine("egal")
		}


		*/




        //exo tp

        /*
                Console.WriteLine("Veuillez saisir le premier nombre");
                int nb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Veuillez saisir le signe");
                char signe = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Veuillez saisir le second nombre");
                int nb2 = Convert.ToInt32(Console.ReadLine());

                bool valide = true;
                int res = 0;
                if (signe == '+')
                {
                    res = nb1 + nb2;
                }
                else if (signe == '-')
                {
                    res = nb1 - nb2;
                }
                else if (signe == '*')
                {
                    res = nb1 * nb2;
                }
                else if (signe == '/')
                {
                    res = nb1 / nb2;
                }
                else
                {
                    Console.WriteLine("Votre signe n'est pas valide ");
                    valide = false;
                }


                if (valide == true)
                {
                    Console.WriteLine("le resultat de votre opération est " + res);
                }
        */


        //exemple du while

        //tant que l'user n'as pas ecris sortie on reste dans la boucle
        /*
		console.WriteLine("veuillez saisir un truc");
		string saisie = Console.ReadLine();

		while(saisie != "sortir"){
			console.WriteLine("veuillez saisir un truc");
		    saisie = Console.ReadLine();
		}
		console.WriteLine("fin boucle");
		*/

        //exempmle for

        /*

		int i =1;
		for(int j = 0; j < 5 ; j++){
			int res = i+j;
			Console.WriteLine(res);
		}
		


		console.WriteLine("veuillez saisir le chiffre  ");
		int nb1 = Convert.toInt32(Console.ReadLine());
				
		console.WriteLine("veuillez saisir la limite  ");
		int limite = Convert.toInt32(Console.ReadLine());

		int res=0;
		for(int i =0 ; i<=limite;i++){
			res = nb1*i;
			Console.WriteLine(nb1 + "x"+ i + "=" + res);
		}


		*/


        //tableau



        //declareation :int[] tabentier;
        //instanciation :tabEntier = new int[5];

		// tab preconstruit : string[] tab = {"","",""};
		/*
        int[] tabEntier = new int[5];
        tabEntier[0] = 1250;
        tabEntier[1] = 2507;
        tabEntier[2] = 5808;
        tabEntier[3] = 8700;
        tabEntier[4] = 5080;
		*/
		//Console.WriteLine(tabEntier);//affichage de la structure mais pas du contenue
		//for
		/*for(int i =0; i< tabEntier.Length; i++)
		{
			Console.WriteLine(tabEntier[i]);
		}
		*/
		/*
        Console.WriteLine("Veuillez entrez votre code pin :");
        int code = Convert.ToInt32(Console.ReadLine());
		bool tr = false;
        foreach (int i in tabEntier  )
		{
           
            if (i== code)
			{
				tr = true;			
			}
			

		}
		if (tr)
		{
            Console.WriteLine("Votre code se trouve bien dans le tableau");

		}
		else
		{
            Console.WriteLine("Votre code ne se trouve pas dans le tableau");

        }

		*/
		String[] tabjour = { "Lundi", "Mardi", "mercredi", "Jeudi", 
			"Vendredi", "Samedi", "Dimanche" };


        //maj du 3e j en mettant ferier
        /*
		tabjour[1] = "Ferier";
        foreach(string i in tabjour)
		{
			Console.WriteLine(i);
		}

		*/
        /*
		int[,] tab2d = new int[2, 6];
		tab2d[0, 0] = 12;
        tab2d[0, 1] = 14;
        tab2d[0, 2] = 8;
        tab2d[0, 3] = 16;
        tab2d[0, 4] = 12;
        tab2d[0, 5] = 10;

		*/

        int[,] tab2d = new int[2, 2];
        tab2d[0, 0] = 15;
        tab2d[0, 1] = 2;
        tab2d[1, 0] = 7;
        tab2d[1, 1] = 1;

		double moyenne = 0;
		int sommescoeff = 0;
		for(int i =0; i < 2; i++)
		{
			int note = tab2d[i, 0];
			int coeff = tab2d[i, 1];
				moyenne += note*coeff;
        }
		moyenne = moyenne / sommescoeff;
		Console.WriteLine("moyenne : " + moyenne);
    }
}