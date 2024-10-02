namespace meteo
{
    
        public static class conversion
        {
            // deux methode static
            //degrés to farenheit 
            //ferenheit to degré 
            //(celsius *9/5)+32
            //(farenheit -32*5/9)

            public static double DegresToFerenheit(double degres)
            {
                return (degres * 9 / 5) + 32;
            }

            public static double FerenheitToDegres(double farenheit)
            {
            return (farenheit - 32) * 5 / 9;
            }


        }
        
    
}