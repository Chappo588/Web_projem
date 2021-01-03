using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeWeb.Models
{
    public class Kullanici
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

        public Yetki Yetki { get; set; }


    }

    public enum Yetki
    {
        Admin = 1,
        Uye = 2
    }
}
