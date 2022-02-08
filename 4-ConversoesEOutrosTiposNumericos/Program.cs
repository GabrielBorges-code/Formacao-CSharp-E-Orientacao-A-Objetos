using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversões e Outros Tipos Númericos");

            //o int é um tipo de variável que suporta valores até 32 bits
            double salario = 1250.50;

            int salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            //o long é um tipo de variável que suporta valores até 64 bits
            long idadeUniverso = 13000000000;
            Console.WriteLine(idadeUniverso);

            //o short é um tipo de variável que suporta valores até 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);
                
            float altura = 1.83f;
            Console.WriteLine(altura);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
