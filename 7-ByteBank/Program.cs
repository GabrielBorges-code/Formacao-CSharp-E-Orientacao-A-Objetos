using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente("Gabriel Borges", "358.456.147-13", "Monitorador de Redes");
            ContaCorrente cc01 = new ContaCorrente(cliente01, 369, 369741, 100);

            Cliente cliente02 = new Cliente("Renata Bailerini", "132.546.777-37", "Developer Java");
            ContaCorrente cc02 = new ContaCorrente(cliente02, 369, 369741, 100);

            Cliente cliente03 = new Cliente("Jose Manoel", "945.216.987-62", "Analista de suporte");
            ContaCorrente cc03 = new ContaCorrente(cliente03, 369, 369741, 100);

            Console.WriteLine();

            Console.WriteLine(cliente01.Nome + "\n"
                + cliente01.CPF + "\n"
                + cliente01.Profissao);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
