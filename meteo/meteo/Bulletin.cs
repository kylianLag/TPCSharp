using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    public class Bulletin
    {
        public DateTime PeriodeDiffusion { get; set; }
        public List<ZoneGeographique> zoneGeographiques { get; set; }

        public Bulletin(DateTime PeriodeDiffusion)
        {
            this.PeriodeDiffusion = PeriodeDiffusion;
            zoneGeographiques = new List<ZoneGeographique>();
        }


        public override string ToString()
        {
            string str = "";
            str += this.PeriodeDiffusion.ToString()+"\n";
            foreach(ZoneGeographique zoneGeographique in this.zoneGeographiques)
            {
                str+="\n"+zoneGeographique.ToString()+"\n";
            }
            return str;
        }

        public Releve AfficherRelever(ZoneGeographique zone)
        {
            try
            {
                if (zoneGeographiques.Contains(zone))
                {
                    return zone.laReleve;
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            return null;
           
        }

        public bool AjouterZone(ZoneGeographique zone)
        {
            if (!zoneGeographiques.Contains(zone))
            {
                zoneGeographiques.Add(zone);
                return true;
            }
            return false;
        }

        public double MoyenneTemperature(string type)
        {
            int i = 0;
            double sommes = 0;
            foreach (ZoneGeographique z in zoneGeographiques)
            {
                sommes += z.laReleve.temperature;
                i++;
            }
            if (type == "c°")
            {
                return(sommes / i);

            }
            return conversion.DegresToFerenheit(sommes / i);
        }

        public ZoneGeographique TemperatureMax(string type)
        {
            if (this.zoneGeographiques.Count == 0)
            {
                return null;
            }
            double temperatureMax = 0;
            ZoneGeographique zoneMax = null;
            foreach(ZoneGeographique z in zoneGeographiques)
            {
                if (z.laReleve.temperature > temperatureMax)
                {
                    temperatureMax = z.laReleve.temperature;
                    zoneMax = z;
                }
            }
            if (type == "c°")
            {
                Console.WriteLine("la température Max est de "+ temperatureMax+"C°");

            }
            else
            {
                Console.WriteLine("la température Max est de " + conversion.DegresToFerenheit(temperatureMax) + "F°");
            }
            return zoneMax;

        }

        public ZoneGeographique TemperatureMin(string type)
        {
            double temperatureMin = this.zoneGeographiques[0].laReleve.temperature;
            ZoneGeographique zoneMin = null;
            foreach (ZoneGeographique z in zoneGeographiques)
            {
                if (z.laReleve.temperature < temperatureMin)
                {
                    temperatureMin = z.laReleve.temperature;
                    zoneMin = z;
                }
            }
            if (type == "c°")
            {
                Console.WriteLine("la température Max est de " + temperatureMin + "C°");

            }
            else
            {
                Console.WriteLine("la température Max est de " + conversion.DegresToFerenheit(temperatureMin) + "F°");
            }
            return zoneMin;


        }
    }
}
