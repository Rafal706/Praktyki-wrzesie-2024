﻿using System.Drawing;
namespace Praktyki2024.stronainternetowa.Models
{
    public class Strona2
    {
        public string Marka { get; set; }
        public string Kolor { get; set; }
        public int Rok_produkcji { get; set; }
        public string Stan { get; set; }
        public string Kraj { get; set; }

        public Strona2() { }

        public Strona2(string marka, string kolor, int rok_produkcji, string stan, string kraj)
        {
            this.Marka = marka;
            this.Kolor = kolor;
            this.Rok_produkcji = rok_produkcji;
            this.Stan = stan;
            this.Kraj = kraj;
        }
    }
}
