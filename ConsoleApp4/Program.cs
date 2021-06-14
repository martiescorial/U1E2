using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Console.WriteLine("N = {0}", N);
            double A = 10.17;
            Console.WriteLine("A = {0}", A);
            char C = 'b';
            Console.WriteLine("C = {0}", C);
            Console.WriteLine("Suma = {0}", N + A);
            Console.WriteLine("Resta = {0}", A - N);
            Console.WriteLine(C + ": " + (int)C);
        }
    }
}
