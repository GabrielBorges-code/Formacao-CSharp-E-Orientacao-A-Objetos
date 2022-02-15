using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Saldo = 1000;
            Console.WriteLine(contaCorrente.CalcularTaxaAdministrativa());
            Console.ReadLine();

        }
    }
}
