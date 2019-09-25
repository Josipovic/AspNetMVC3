using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNet3Vjezba2.Models
{
    public class KontaktPodaci
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int PostanskiBroj { get; set; }
        public string Mjesto { get; set; }
        public string Ulica { get; set; }
        public int KucniBroj { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
    }
}