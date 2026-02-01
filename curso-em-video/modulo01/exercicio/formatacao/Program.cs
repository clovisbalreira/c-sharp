using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace formatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            float salario = 550.7556f;
            int idade = 22;
            Console.WriteLine($"Muito prazer em te conhecer, {nome}!!!");
            Console.WriteLine($"Muito prazer em te conhecer, {nome}!!!");
            Console.WriteLine($"Muito prazer em te conhecer, {nome, 20}!!!");
            Console.WriteLine($"Muito prazer em te conhecer, {nome, -20}!!!");
            Console.WriteLine($"O {nome, 10} tem {idade, 5:D3} anos ganha {salario, 10:C} por mês");
            Console.WriteLine($"O {nome, 10} ganha {salario, 10:C3} por mês");
            int numero = 13;
            Console.WriteLine($"O numero foi {numero:X}");
            Console.WriteLine($"O numero foi {numero:E}");
            
            Console.ReadKey();
        }
    }
}
/*
 * :C Monetário ( currency )
 * :D Decimal ( inteiro )
 * :N Número ( real )
 * :E Cientifíco
 * :X Hexadecimal
 */

