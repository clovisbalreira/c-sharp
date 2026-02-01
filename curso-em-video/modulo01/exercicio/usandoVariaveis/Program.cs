using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace usandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Começa com uma letra ou sublklinha ou @
             * Maiusculas e minusculas fazem diferença
             * so usa letras, numeros e sublinhado
             * Podemos usar acentos
             * Nao pode usar palavras reservadas
             * Nao pode usar simbolos
            */
            var n = 0;
            Console.WriteLine("O valor de n é " + n);
            Console.WriteLine("N é do tipo" + n.GetType());
            byte idade = 45;
            Console.WriteLine("A idade é " + idade);
            string nome = "Ana Maria";
            Console.WriteLine("O nome é " + nome);
            long cpf = 12345678901;
            Console.WriteLine("O cpf é " + cpf);
            bool casado = false;
            Console.WriteLine("O casado é " + casado);
            float media = 10.5f;    
            Console.WriteLine("O media é " + media);
            decimal estrela = 1000.55m;
            Console.WriteLine("A estrela é " + estrela);
            Console.ReadKey();
        }
    }
}