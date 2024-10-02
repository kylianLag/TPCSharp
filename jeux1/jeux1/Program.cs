namespace jeux1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            

            Random alea = new Random();
            Personnage perso = new Personnage(alea.Next(5), alea.Next(5));
            Destination desti = new Destination(alea.Next(5), alea.Next(5));
            while(perso.getPosX()  == desti.getPosX() && perso.getPosY() == desti.getPosY())
            {
                desti.posX = alea.Next(5);
                desti.posY = alea.Next(5);

            }
            Application.Run(new Form1(perso , desti));
        }

    }
}