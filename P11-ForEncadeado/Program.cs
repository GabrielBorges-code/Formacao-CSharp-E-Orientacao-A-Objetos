using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For encadeado");

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                    if(j <= i)
                        break;
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("--- FORMA DIFERENTE DE FAZER A MESMA COISA ---");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j);
                  

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
