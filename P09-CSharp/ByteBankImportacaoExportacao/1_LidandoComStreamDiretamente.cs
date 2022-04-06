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
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes Lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte + " ");
            //}
        }

        static void TestaExercicio()
        {
            var fs = new FileStream("C:/Users/gabri/source/repos/Formacao-CSharp-OO/P09-CSharp/teste.txt", FileMode.Open);

            var buffer = new byte[1024];
            var encoding = Encoding.ASCII;

            var bytesLidos = fs.Read(buffer, 0, 1024);
            var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);


            Console.Write(conteudoArquivo);

            Console.ReadLine();
        }

        static void TestaExercicio2()
        {

            using (var fs = new FileStream("C:/Users/gabri/source/repos/Formacao-CSharp-OO/P09-CSharp/nomes.txt", FileMode.Open))
            {
                var buffer = new byte[128]; // Buffer de 128 bytes
                var encoding = Encoding.UTF8;

                var bytesLidos = -1;

                while (bytesLidos != 0)
                {
                    bytesLidos = fs.Read(buffer, 0, 128);
                    var conteudo = encoding.GetString(buffer, 0, 128);
                    Console.Write(conteudo);
                }
            }
        }
    }
}