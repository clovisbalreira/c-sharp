using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão implicita");
            int a = 5;
            float b = a; 
            Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());
            Console.WriteLine("Conversão explicita");
            float c = 8.75f;
            int d = (int)c; 
            Console.WriteLine("O valor de c é " + c + " do tipo " + c.GetType());
            Console.WriteLine("O valor de d é " + d + " do tipo " + d.GetType());
            Console.WriteLine("Conversão por classe auxiliar");
            float e = 8.75f;
            int f = Convert.ToInt16(e);
            Console.WriteLine("O valor de e é " + e + " do tipo " + e.GetType());
            Console.WriteLine("O valor de f é " + f + " do tipo " + f.GetType());
            Console.ReadKey();
        }
    }
}

/*
 * Conversão implicita
 * Conversão explicita ( type casting )  
 * Conversão por classe auxiliar
 */