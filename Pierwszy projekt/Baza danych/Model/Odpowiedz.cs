using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.Model
{
    public class Odpowiedz
    {
        public int Id { get; set; }
        public string TrescOdpowiedzi { get; set; }
        public bool CzyPrawidlowa { get; set; }
        public int IdPytania { get; set; }
    }
}
