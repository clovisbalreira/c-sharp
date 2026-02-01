using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datasHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;
            Console.WriteLine("A data atual é dia " + dia + " do mês " + mes + " do ano " + ano);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
            Console.ReadKey();
        }   
    }
}