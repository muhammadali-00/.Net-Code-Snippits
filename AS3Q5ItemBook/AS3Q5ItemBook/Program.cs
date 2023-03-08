using System;

namespace AS3Q5ItemBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Items \n");

            Book b = new Book("34","Tokien","Lord of The Rings");
            Console.WriteLine(b.getListing());

            Console.WriteLine();

            Periodical p = new Periodical(1234,"Times");
            Console.WriteLine(p.getListing());

            Console.WriteLine();

            Book b1 = new Book("4567", "Tolstoy", "War and Peace");
            Console.WriteLine(b1.getListing());

            Console.WriteLine();

            Book b2 = new Book("7890", "Lewis Carrol", "Alice in Wonderland");
            Console.WriteLine(b2.getListing());

            Console.WriteLine();

            Periodical p1 = new Periodical(45, "New Yorker");
            Console.WriteLine(p1.getListing());
        }
    }
}
