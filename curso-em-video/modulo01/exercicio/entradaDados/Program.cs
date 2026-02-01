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
            Console.Write("Qual é seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito Prazer em conhecer " + nome);

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int d = num * 2;
            Console.WriteLine("O dobro de " + num + " é " + d);

            Console.Write("Digite um número: ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            int t = num * 3;
            Console.WriteLine("O dobro de " + num + " é " + t);

            Console.ReadKey();
        }
    }
}