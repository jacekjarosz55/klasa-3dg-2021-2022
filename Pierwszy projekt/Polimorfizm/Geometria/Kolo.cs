using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Kolo : Figura
    {
        private readonly double promien = 5;

        public Kolo(string nazwa, double promien): base(nazwa)
        {
            this.promien = promien;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Promien " + promien);
        }

        public override void ObliczPole()
        {
            pole = Math.PI * promien * promien;
        }

        public override void ObliczObwod()
        {
            obwod = 2 * Math.PI * promien;
        }
    }
}
