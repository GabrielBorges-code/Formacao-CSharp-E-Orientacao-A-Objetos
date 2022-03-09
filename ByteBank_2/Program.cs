using ByteBank_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch no Main \n" + ex.Message);
            }

            Console.WriteLine("Execução finalizada");
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //----------------------------------------------------

            //LeitorDeArquivo leitor = null;
           
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //finally
            //{
            //    Console.WriteLine("Executando o Finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();

            //    }

            //}
        }
        public static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(358, 9874);
                ContaCorrente conta2 = new ContaCorrente(357, 9813);

                //conta1.Transferir(1000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);

                Console.WriteLine("informações da INNER EXCEPTION\n" + e.InnerException.Message + "\n" + e.InnerException.StackTrace);
            }
           

        }
    }
}
