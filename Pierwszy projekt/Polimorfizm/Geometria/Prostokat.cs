using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Prostokat : Czworokat
    {
        public Prostokat(string nazwa, double bokA, double bokB)
            : base(nazwa, bokA, bokB, bokA, bokB, bokB, bokB)
        {

        }

        public new void ObliczPole()
        {
            pole = bokA * bokB;
        }
    }
}
