using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace tiposPrimitivos{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O tipo usa 1 byte byte vai de " + byte.MinValue + " até " + byte.MaxValue);
            Console.WriteLine("O tipo usa 1 byte sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);
            Console.WriteLine("O tipo usa 2 byte short vai de " + short.MinValue + " até " + short.MaxValue);
            Console.WriteLine("O tipo usa 2 byte ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue);
            Console.WriteLine("O tipo usa 4 byte int vai de " + int.MinValue + " até " + int.MaxValue);
            Console.WriteLine("O tipo usa 4 byte uint vai de " + uint.MinValue + " até " + uint.MaxValue);
            Console.WriteLine("O tipo usa 4 byte long vai de " + long.MinValue + " até " + long.MaxValue);
            Console.WriteLine("O tipo usa 4 byte ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue);
            Console.WriteLine("O tipo usa 1 char vai de " + char.MinValue + " até " + char.MaxValue);
            Console.WriteLine("O string");
            Console.WriteLine("O tipo usa 32 byte float vai de " + float.MinValue + " até " + float.MaxValue);
            Console.WriteLine("O tipo usa 64 byte double vai de " + double.MinValue + " até " + double.MaxValue);
            Console.WriteLine("O tipo usa 128 byte decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue);
            Console.WriteLine("O tipo bool vai de " + bool.TrueString + " até " + bool.FalseString);
            Console.WriteLine("O tipo enum");
            Console.WriteLine("O tipo struct");
            Console.WriteLine("O tipo object");
            Console.ReadKey();
        }
    }
}