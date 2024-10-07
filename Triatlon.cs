using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga1007
{
    internal class Triatlon
    {
        public string Nev { get; set; }
        public int Year { get; set; }
        public int Rajtszam { get; set; }
        public string Neme {  get; set; }
        public string Kategoria { get; set; }
        public DateTime Uszas { get; set; }
        public DateTime Elso { get; set; }
        public DateTime Kerekpar { get; set; }
        public DateTime Masodik { get; set; }
        public DateTime Futas { get; set; }

        public override string ToString()
        {
            return
            $"\tNev: {Nev}\n" +
            $"\tSzületési év: {Year}\n" +
            $"\tRajtszám: {Rajtszam}\n" +
            $"\tNem: {Neme}\n" +
            $"\tKategória: {Kategoria}\n" +
            $"\tÚszás ideje: {Uszas}\n" +
            $"\tElső depóban töltött idő: {Elso}\n" +
            $"\tKerékpározás ideje: {Kerekpar}\n" +
            $"\tMásodik depóban töltött idő: {Masodik}\n" +
            $"\tFutás ideje: {Futas}\n";
        }

        public Triatlon(string row)
        {
            var v = row.Split(';');
            Nev = v[0];
            Year = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            Neme = v[3];
            Kategoria = v[4];
            Uszas = DateTime.Parse(v[5]);
            Elso = DateTime.Parse(v[6]);
            Kerekpar = DateTime.Parse(v[7]);
            Masodik = DateTime.Parse(v[8]);
            Futas = DateTime.Parse(v[9]);
        }
    }
}
