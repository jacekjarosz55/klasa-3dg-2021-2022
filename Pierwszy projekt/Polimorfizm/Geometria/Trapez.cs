using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Trapez : Czworokat
    {
        public Trapez(string nazwa, double bokA,
                      double bokB, double bokC,
                      double bokD,
                      double wysokoscA):
            base(nazwa, bokA, bokB, bokC, bokD, wysokoscA, wysokoscA)
        {

        }

        public new void ObliczPole()
        {
            pole = (bokA + bokC) * wysokoscA / 2;
        }
    }
}
