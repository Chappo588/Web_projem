using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeWeb.Models
{
    public class Otel
    {
        public int Id { get; set; }

        public string OtelAd { get; set; }

        public double SehirMerkeziUzaklik { get; set; }

        public Boolean Havuz { get; set; }

        public Boolean Bar { get; set; }

        public Boolean Spa { get; set; }

        public Boolean Restoran { get; set; }

        public Boolean Otopark { get; set; }

        public string Resim { get; set; }
        
        public string Goster { get; set; }

        public int TurId { get; set; }
        public Tur Tur { get; set; }


    }
}
