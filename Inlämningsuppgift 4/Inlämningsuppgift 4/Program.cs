using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
            }
            for (int i = 100; i >= 1; i--)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(i);
            }

            for(int x = 1; x <= 10; x++)
            {
                for(int y = 1; y <= 5; y++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(x * y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("   x = " + x + " y = " + y);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to exit");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }
    }
}
