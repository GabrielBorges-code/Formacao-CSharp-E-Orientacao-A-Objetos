using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EscopoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Teste");
            double salario = 3300.0;

            if (salario < 2600.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");

            }

            if (salario < 3750.0)
            {
                Console.WriteLine("A sua aliquota é de 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636");

            }


            Console.WriteLine(salario);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
