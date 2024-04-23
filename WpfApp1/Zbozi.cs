using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Zbozi
    {
        public Zbozi(string nazev, string pocet, string cena, int id)
        {
            Nazev = nazev;
            Pocet = pocet;
            Cena = cena;
            Id = id;
        }

        public string Nazev { get; set; }
        public string Pocet { get; set; }
        public string Cena { get; set; }
        public int Id { get; set; }

        public override string? ToString()
        {
            return $"{Nazev} {Pocet} {Cena}";
        }

    }
}
