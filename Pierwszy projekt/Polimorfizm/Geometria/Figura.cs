using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    abstract class Figura
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

        public abstract void ObliczPole();

        public abstract void ObliczObwod();

        public virtual void Info()
        {
            Console.WriteLine("Informacja o obiekcie " + nazwa);
            Console.WriteLine("Pole " + pole);
            Console.WriteLine("Obwod " + obwod);
        }
    }

    
    interface IXyz
    {
        public void A();
        public void B();
        public void C();
        public void D();
    }

    class Abc: IXyz
    {
        public override void A()
        {

        }
        public override void B()
        {

        }
        public override void C()
        {

        }
        public override void D()
        {

        }
    }
    
}
