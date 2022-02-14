using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc01 = new ContaCorrente("Gabriela Munique", 886, 886146, 0);


            Console.WriteLine("\n" + cc01.saldoDaConta());
            cc01.Depositar(100);
            cc01.Sacar(50);
            Console.WriteLine(cc01.saldoDaConta() + "\n");

            ContaCorrente cc02 = new ContaCorrente("João da Penha", 886, 886157, 30.5);
            
            cc01.Transferir(300, cc02);

            Console.WriteLine("\n" + cc01.saldoDaConta() + "\n" +
                cc02.saldoDaConta());


            Console.ReadLine();

        }
    }
}
