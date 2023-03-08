using System;

namespace AS3Q7Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Toyota",2002,2400000);
            c.Print();

            Console.WriteLine();

            ThirdPartyPolicy tp = new ThirdPartyPolicy("No Comments","Muhammad Ali",14526,c,12);
            Console.WriteLine("Premium : " + tp.Calcpayment(125));
            tp.ToStrings();

            Console.WriteLine();

            ComprehensivePolicy cp = new ComprehensivePolicy(23,10,"Hadiqa",14526,c,15);
            Console.WriteLine("Premium : "+cp.Calcpayment(125));
            cp.ToStrings();



        }
    }
}
