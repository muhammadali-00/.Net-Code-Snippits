using System;

namespace ASQ4Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            ResizeableCircle RC = new ResizeableCircle(124);
            Console.WriteLine(RC.toStrings());
        }
    }
}
