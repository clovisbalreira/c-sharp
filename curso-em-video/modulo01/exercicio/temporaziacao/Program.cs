using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace temporaziacao
{
    class Program
    {
        static async void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;
            Console.WriteLine("A data atual é dia " + dia + " do mês " + mes + " do ano " + ano);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
            Thread.Sleep(1000);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
            Thread.Sleep(1000);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
            Thread.Sleep(1000);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
            await Task.Delay(2000);
            Console.WriteLine("A hora atual é hora " + hora + " minutos " + minuto + " segundos " + segundo);
        
        }
    }
}