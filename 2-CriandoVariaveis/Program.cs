using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 2022 - 1998 ;
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            string nome = "Gabriel Borges";

            Console.WriteLine("Minha idade é " + idade + "Anos de idade");
            
            // Não quebra a linha
            Console.Write("Meu nome " + nome + " de Moura\n");

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
