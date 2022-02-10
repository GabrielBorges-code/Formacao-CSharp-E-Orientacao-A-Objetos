using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idade = 9;
            bool acompanhada = true;

            if (idade >= 18)
            {
                Console.WriteLine(idade + " anos, maior de idade, pode entrar");
            }
            else if (idade < 18 && acompanhada == true)
            {
                Console.WriteLine(idade + " anos, menor de idade, mas está acompanhada, pode entrar");

            }
            else
            {
                Console.WriteLine(idade + " anos, menor de idade, não pode entrar");
            }

            Console.WriteLine(acompanhada);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();

        }
    }
}
