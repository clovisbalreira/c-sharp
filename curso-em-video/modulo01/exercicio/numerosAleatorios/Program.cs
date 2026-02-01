using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ger = new Random();
            int n1 = ger.Next();
            int n2 = ger.Next(10);
            int n3 = ger.Next(5, 20);
            Console.WriteLine("Acabei de gerar o numero " + n1);
            Console.WriteLine("Acabei de gerar o numero " + n2);
            Console.WriteLine("Acabei de gerar o numero " + n3);

            Console.ReadKey();
        }
    }
}