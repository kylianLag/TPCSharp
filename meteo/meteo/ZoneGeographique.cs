using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    public class ZoneGeographique
    {
        public double longitude { get;set; }
        public double latitude { get; set; }

        public string lieuDit { get; set; }

        public Releve laReleve { get; set; }

        public ZoneGeographique(double longitude, double latitude, string lieuDit, Releve laReleve)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.lieuDit = lieuDit;
            this.laReleve = laReleve;
            this.laReleve = laReleve;
        }


        public override string ToString()
        {
            return "[LONGITUDE] : "+this.longitude+"\n [LATITUDE] : "+this.latitude+"\n[LIEUDIT] : "+this.lieuDit+"\n"+laReleve.ToString();
        }
    }
}
