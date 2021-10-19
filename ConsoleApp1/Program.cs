using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class A
        {

        }

        class B:A
        {
            public B(Object a1, Object a2, Object a3, Object a4)
            {
                this.a1 = a1;
                this.a2 = a2;
                this.a3 = a3;
                this.a4 = a4;
            }
            public Object a1;
            public Object a2;
            public Object a3;
            public Object a4;
        }
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            A a4 = new A();
            B b5 = new B(a1,a2,a3,a4);
        }
    }
}
