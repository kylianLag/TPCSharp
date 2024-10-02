using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    public class Releve
    {
       public double temperature { get; set; }
        public double humidite { get; set; }
        public double precipitation { get; set; }
        public double vent { get; set; }
        public string Etat { get; set; }

    public Releve(double temperature, double humidite, double precipitation, double vent , string etat)
        {
            this.temperature = temperature;
            this.humidite = humidite;
            this.precipitation = precipitation;
            this.vent = vent;
            this.Etat = etat;
        }

        public override string ToString()
        {
            return "[TEMPERATURE] : "+this.temperature+"\n[HUMIDITE] :  "+this.humidite+"\n[PRECIPITATION] : "+this.precipitation+"\n[VENT] : "+this.vent+"\n[ETAT] :"+this.Etat;
        }
    }
}
