using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AP3V
{
    class Program
    {
        static void Main(string[] args)
        {
            Festival festival = new Festival();
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Wallon\Desktop\film.csv"));
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                Film film = new Film(values[0], values[2], values[3], values[4]);

                festival.ListeFilm.Add(film);


            }
            

            foreach(Film f in festival.ListeFilm)
            {
                Console.WriteLine(f);
            }

        }

    }
}

