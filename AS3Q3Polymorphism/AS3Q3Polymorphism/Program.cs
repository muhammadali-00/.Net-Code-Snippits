using System;

namespace AS3Q3Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student("Muhammad Ali","Malir Cantt","Computer Science",2022,500000);
            Console.WriteLine(s.toStrings());
            
            staff st = new staff("Hadiqa", "Landhi", "Beacon House", 45000);
            Console.WriteLine(st.toStrings());
            
        }
    }
}
