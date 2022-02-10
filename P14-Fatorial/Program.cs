using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial; 

            Console.WriteLine("Fatorial");

            Console.Write("Digite um valor para calcular a fatorial: ");
            numero = int.Parse(Console.ReadLine());
    
            fatorial = 1;

            if (numero < 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                for (int cont = numero; cont >= 1; cont--)
                {
                    fatorial *= cont;
                    Console.WriteLine(fatorial);

                }

            }

            Console.ReadLine();

        }
    }
}
