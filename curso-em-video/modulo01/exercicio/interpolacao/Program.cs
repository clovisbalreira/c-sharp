using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}! Tudo Bem?");
            float salario;
            Console.Write("Qual seu salário: ");
            float.TryParse(Console.ReadLine(), out salario);
            Console.WriteLine($"Você ganha {salario:C} por mês!");
            Console.ReadKey();
        }
    }
}