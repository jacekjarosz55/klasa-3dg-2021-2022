using System;
using System.Collections.Generic;
using System.Text;

namespace Terminarz_siłownia.Baza_danych.Model
{
    class Osoba
    {
        public Osoba(string Imie_Nazwisko)
        {
            this.Imie_Nazwisko = Imie_Nazwisko;
        }
        public int Id { get; set; }
        public string Imie_Nazwisko { get; set; }
    }
}
