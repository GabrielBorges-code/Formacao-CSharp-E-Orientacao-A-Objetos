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
        static void TestaStreamReader()
        {

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var contaCorrente = ConverterStringParaContaCorrente(linha);

                        Console.WriteLine($"Nº Conta: {contaCorrente.Numero}, " +
                            $"Nº Agência: {contaCorrente.Agencia}, " +
                            $"Titular: {contaCorrente.Titular.Nome}, " +
                            $"Saldo R$ {contaCorrente.Saldo}");
                        //Console.WriteLine(linha);

                    }
                }
            }
            Console.ReadLine();
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            resultado.Depositar(double.Parse(saldo));
            resultado.Titular = titular;

            return resultado;

        }
    }
}
