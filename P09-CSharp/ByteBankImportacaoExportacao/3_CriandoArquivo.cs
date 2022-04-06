using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,789456,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWrite()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    escritor.WriteLine("654,98745,2500.70,Antonio Souza");
                }
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {

                    for (int i = 0; i < 1000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");
                        escritor.Flush();
                        Console.WriteLine($"Linha {i}, tecle enter para continuar");
                        Console.ReadLine();
                    }

                }
            }
        }
    }
}
