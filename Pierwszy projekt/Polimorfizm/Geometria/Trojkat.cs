using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Trojkat : Figura
    {
        protected double bokA, bokB, bokC;
        protected double wysokoscA;

        public Trojkat(string nazwa, double bokA,
                       double bokB, double bokC,
                       double wysokoscA): base(nazwa)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
            this.wysokoscA = wysokoscA;
        }

        public void ObliczPole()
        {
            pole = bokA * wysokoscA / 2;
        }

        public void ObliczObwod()
        {
            obwod = bokA + bokB + bokC;
        }
        public new void Info()
        {
            base.Info();
            Console.WriteLine("Bok a " + bokA);
            Console.WriteLine("Bok b " + bokB);
            Console.WriteLine("Bok c " + bokC);
            Console.WriteLine("Wysokosc na bok A " + wysokoscA);
        }
    }
}
