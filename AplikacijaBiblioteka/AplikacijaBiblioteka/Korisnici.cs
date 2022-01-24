using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaBiblioteka
{
    internal class Korisnici
    {
        int ID;
        string Ime, Prezime;

        public Korisnici(int iD, string ime, string prezime)
        {
            ID = iD;
            Ime = ime;
            Prezime = prezime;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
    }
}
