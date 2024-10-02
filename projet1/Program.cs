class Program{

	public static void Main(String[] args){
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
		int nb1=  Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Veuillez saisir le signe");
		char signe= Convert.toChar(Console.ReadLine());

		Console.WriteLine("Veuillez saisir le second nombre");
		int nb2=  Convert.ToInt32(Console.ReadLine());

		bool valide = true;
		int res =0;
		if(signe == '+'){
			 res = nb1+nb2;
		}else if(signe == '-'){
			 res = nb1-nb2;
		}else if(signe == '*'){
			 res = nb1*nb2;
		}else if(signe == '/'){
			 res = nb1/nb2;
		}else{
			console.WriteLine("Votre signe n'est pas valide ");
			valide= false;
		}


		if(valide == true){
			console.WriteLine("le resultat de votre opération est " + res);
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


		//exemple foreach 





	}
}