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
        static void Main(string[] args)
        {
            File.WriteAllText("EscrevendoComAClasseFile.txt", "Testando a escrita");

            Console.WriteLine("EscrevendoComAClasseFile");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine("Tamho em bytes: " + bytesArquivo.Length );

            var linhas = File.ReadAllLines("contas.txt");

            Console.WriteLine("Quantidade de linhas " + linhas.Length);

            foreach (var line in linhas)
            {
                Console.WriteLine(line);
            }

            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine(nome);

            //UsarStreamDeEntrada();

            Console.ReadLine();
        }
    }
} 
 