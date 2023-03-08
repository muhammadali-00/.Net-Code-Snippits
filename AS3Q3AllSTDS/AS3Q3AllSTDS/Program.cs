using System;

namespace AS3Q3AllSTDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Baz b = new Baz();
            b.toString();
            b.Method1();
            b.Method2();

            Console.WriteLine();

            Bar br = new Bar();
            br.toString();
            br.Method1();
            br.Method2();

            Console.WriteLine();

            Mumble m = new Mumble();
            m.toString();
            m.Method1();
            m.Method2();

            Console.WriteLine();

            Foo f = new Foo();
            f.toString();
            f.Method1();
            f.Method2();
        }
    }
    class Foo
    {
        public virtual void Method1()
        {
            Console.WriteLine("Foo 1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Foo 2");
        }

        public virtual void toString()
        {
            Console.WriteLine("Foo ");
        }
    }

    class Bar : Foo
    {
        public override void Method2()
        {
            Console.WriteLine("Bar 2");
        }
    }
    class Baz : Foo
    {
        public override void toString()
        {
            Console.WriteLine("Baz ");
        }
        public override void Method1()
        {
            Console.WriteLine("Baz 1");

        }
       

    }

    class Mumble: Baz
    {
        public override void Method2()
        {
            Console.WriteLine("Mumble 2");
        }
    }

}
