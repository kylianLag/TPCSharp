namespace meteo
{
    class Program 
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("quel Ferenheit ?");
            double ferenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(conversion.FerenheitToDegres(ferenheit));

            Console.WriteLine("quel degrés ?");
            double degres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(conversion.DegresToFerenheit(degres));
            DateTime date = new DateTime(2015);
            Bulletin bulletin = new Bulletin(date);
            Releve lareleve = new Releve(1, 1, 1, 1, "1");
            Releve lareleve2 = new Releve(10, 10, 10, 10, "10");
            Releve lareleve3 = new Releve(100, 100, 100, 100, "100");
            ZoneGeographique zone1 = new ZoneGeographique(1, 1, "a",lareleve);
            ZoneGeographique zone2 = new ZoneGeographique(10, 10, "a0", lareleve2);
            ZoneGeographique zone3 = new ZoneGeographique(100, 100, "a00", lareleve3);
            bulletin.AjouterZone(zone1);
            bulletin.AjouterZone(zone2);
            bulletin.AjouterZone(zone3);
            Console.WriteLine("la plus haute temperature est de ");
            bulletin.TemperatureMax("c°");


        }


    }
}