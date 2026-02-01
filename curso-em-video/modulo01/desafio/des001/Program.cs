using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("C# é\n\"SUPER\"\nFácil!\a");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("C# é\n\"SUPER\"\nFácil!\a");
            Console.ReadKey();
        }
    }
}