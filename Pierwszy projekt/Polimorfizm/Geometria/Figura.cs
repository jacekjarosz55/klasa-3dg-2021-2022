using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Figura
    {
        protected string nazwa;
        protected double pole;
        protected double obwod;

        public Figura(string nazwa)
        {
            this.nazwa = nazwa;
            pole = 0;
            obwod = 0;
        }

        public void Info()
        {
            Console.WriteLine("Informacja o obiekcie " + nazwa);
            Console.WriteLine("Pole " + pole);
            Console.WriteLine("Obwod " + obwod);
        }
    }
}
