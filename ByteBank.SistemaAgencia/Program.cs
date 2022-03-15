using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textoVazio = "";

            ExtratorValorDeArgumentosURL evda = ExtratorValorDeArgumentosURL(textoVazio);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            Console.WriteLine(url);

            string urlTeste = url.Substring(7);
            //Console.WriteLine(urlTeste);

            string [] urlTeste2 = url.Split('?');
            
            string argumento = "";

            foreach (var palavras in urlTeste2)
            {
                argumento = palavras;
            }

            Console.WriteLine(argumento);
            
            int indiceInterrocagacao = url.IndexOf("?");

            string argumento2 = url.Substring(indiceInterrocagacao + 1);
            Console.WriteLine(argumento2);



            Console.ReadLine();
        }

        private static ExtratorValorDeArgumentosURL ExtratorValorDeArgumentosURL(string textoVazio)
        {
            throw new NotImplementedException();
        }
    }
}
