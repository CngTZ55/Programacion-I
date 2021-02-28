using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miprimerprograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int a = 5;
            int b = 9;
            int c = 3;

            //Números con la forma aacb
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Número con la forma: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("aacb");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}{0}{2}{1}", a, b, c);
            Console.WriteLine(" ");

            //Números con la forma bca
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Número con la forma: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("bca ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{1}{2}{0}", a, b, c);
            Console.WriteLine(" ");

            //Números con la forma bcbc
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Número con la forma: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("bcbc ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{1}{2}{1}{2}", a, b, c);

            Console.ReadLine();

        }
    }
}
