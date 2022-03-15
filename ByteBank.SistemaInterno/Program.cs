using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022,02,22);
            DateTime hoje = DateTime.Now;

            TimeSpan diferençaAnos = hoje - data;

            Console.WriteLine("Data anterior " + data + "\nData de hoje " + hoje + "\nDiferença entre as datas " + diferençaAnos.Days);

            Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(diferençaAnos));

            Console.ReadLine();
        }

       
    }
}
