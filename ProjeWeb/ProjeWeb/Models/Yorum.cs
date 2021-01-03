using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeWeb.Models
{
    public class Yorum
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yazi { get; set; }

        public DateTime Tarih { get; set; }

        public int OtelId { get; set; }
        public Otel Otel { get; set; }

    }
}
