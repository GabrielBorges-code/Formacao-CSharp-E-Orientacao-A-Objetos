using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_TabuadaDeMultiplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int mult = 1; mult <= 10; mult ++)
            {
                for (int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine(mult + " * " + cont + " = " + (mult * cont));
                }
                Console.WriteLine("\n");    
            }

            Console.ReadLine();
        }
    }
}
