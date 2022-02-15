using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TestFigur
    {

        public void Test1()
        {
            Trojkat trojkat = new Trojkat("Trojkat", 3, 4, 5, 2.5);
            trojkat.ObliczObwod();
            trojkat.ObliczPole();
            trojkat.Info();

            TrojkatRownoboczny trojkatRownoboczny = new TrojkatRownoboczny("Tr", 4, 2.5);
            trojkatRownoboczny.ObliczObwod();
            trojkatRownoboczny.ObliczPole();
            trojkatRownoboczny.Info();
        }
    }
}
