using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Titular cliente01 = new Titular("Gabriela Munique", "123.456.789.10", "Analista de Sistemas");
            ContaCorrente cc01 = new ContaCorrente(cliente01, 886, 886146, 0);

            Console.WriteLine();

            cc01.Depositar(15);
            Console.WriteLine(cc01.SaldoDaConta());
            
            cliente01.Profissao = "Desenvolvedora C#";

            Console.WriteLine(cliente01.Nome + "\n" +
                cliente01.CPF + "\n" +
                cliente01.Profissao);

            Console.WriteLine();

            Titular cliente02 = new Titular("João da Penha", "987.654.321.00", "Suporte de Infraestrutura");
            ContaCorrente cc02 = new ContaCorrente(cliente02, 886, 886157, 30.5);

            Console.ReadLine();


        }
    }
}
