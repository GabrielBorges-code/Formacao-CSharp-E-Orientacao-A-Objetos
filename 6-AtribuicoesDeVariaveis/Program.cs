using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Atributos de Variaveis");

            int idade = 23;
            int minhaIdade = idade;

            idade = 20;

            Console.WriteLine("Idade " + idade); //20
            Console.WriteLine("Minha idade é " + minhaIdade); //23

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
