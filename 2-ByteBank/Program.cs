using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc01 = new ContaCorrente();

            cc01.titular = "Gabriela";

            cc01.saldo -= 10;

            Console.WriteLine(cc01.titular + "\n" +
              cc01.numero + "\n" +
              cc01.numero + "\n" +
              cc01.saldo);

            Console.ReadLine();

        }
    }
}
