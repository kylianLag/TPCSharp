namespace LeJustePrix
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

            Vitrine vitrine = new Vitrine();
            Article article1 = new Article("Chips", "beau paquet de chips Auchan", 2);
            Article article2 = new Article("Table", "table basse Ikea", 20);
            vitrine.add(article1);
            vitrine.add(article2);

            ApplicationConfiguration.Initialize();
            Application.Run(new formRegle(vitrine));
        }
    }
}