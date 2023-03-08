using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Values of a,b and c");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation qe = new QuadraticEquation(a,b,c);
           
            
            qe.Roots();
        }
    }
}
