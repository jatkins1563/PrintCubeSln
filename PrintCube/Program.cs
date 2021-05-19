using System;

namespace PrintCube
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var cube = 0;

            while (i <= 25)
            {
                cube = i * i * i;
                Console.WriteLine($"The cube of {i} is {cube}.");
                i += 2;
            }
        }
    }
}
