using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Test
{
    class A
    {
        //...
        public void XYZ()
        {

        }
    }

    class B : A
    {
        //...
        public void XYZ2()
        {

        }
    }

    class C : A
    {
        //...
    }

    class D : B
    {
        //...
    }

    class E: B
    {
        public new void XYZ2()
        {
            XYZ();
            base.XYZ();
        }

        public new void XYZ()
        {
            //...
            base.XYZ();
        }

        public void XYZ(int x)
        {

        }

    }

    class F : B
    {
        public void XYZ(int x, float b)
        {

        }

    }



    class Testowa
    {
        public void test()
        {
            B b = new B();
            b.XYZ();

            E e = new E();
            e.XYZ();

            F f = new F();
            f.XYZ();
        }

    }


}
