using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CalculandoPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 09 - Calculando Poupança");

            double jurosAoMes = 0.0036;
            double investimentoInicial = 1000;
            int qtdMeses = 12;

            for (int i = 0; i < qtdMeses; i++)
            {
                double rendimentos = (investimentoInicial * jurosAoMes);
                investimentoInicial = investimentoInicial + rendimentos;
                Console.WriteLine("No mês " + (i + 1) + " você teve R$ " + rendimentos.ToString("N2") + " de rendimento");

                Console.WriteLine("Seu saldo atual é " + investimentoInicial.ToString("N2"));

            }


            Console.WriteLine("Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
