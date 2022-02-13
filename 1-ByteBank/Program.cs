
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc01 = new ContaCorrente();

            cc01.titular = "Gabriela";
            cc01.numeroAgencia = 886;
            cc01.numero = 886146;
            cc01.saldo = 144.5;

            Console.WriteLine(cc01.titular + "\n" +
                cc01.numero + "\n" +
                cc01.numero + "\n" +
                cc01.saldo);

            Console.WriteLine("---------");
            ContaCorrente cc02 = new ContaCorrente();

            cc02.titular = "Bruno";
            cc02.numeroAgencia = 886;
            cc02.numero = 886145;
            cc02.saldo = 1000.6;

            Console.WriteLine(cc02.titular + "\n" +
                cc02.numero + "\n" +
                cc02.numero + "\n" +
                cc02.saldo);

            Console.ReadLine();


        }
    }
}
