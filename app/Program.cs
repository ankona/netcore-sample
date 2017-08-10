using System;
using static System.Console;
using Library;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a new line y...");
            WriteLine($"The answer is {new Thing().Get(19, 23)}");
        }
    }
}
