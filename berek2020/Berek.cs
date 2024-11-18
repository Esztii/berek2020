using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Berek
    {
        public string Nev { get; set; }
        public bool Neme { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public override string ToString()
        {
            return $"{Nev}: {(Neme ? "férfi" : "nő")}, {Reszleg}, {Belepes}, {Ber}";
        }

        public Berek(string sor) 
        {
            string[] db = sor.Split(";");
            Nev = db[0];
            Neme = db[1] == "férfi";
            Reszleg = db[2];
            Belepes = int.Parse(db[3]);
            Ber = int.Parse(db[4]);
        }

    }
}
