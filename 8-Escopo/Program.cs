using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Escopo");

            int idade = 16;
            bool acompanhada = false;
            string msgAdicional;

            if (acompanhada == true)
            {
                msgAdicional = "José está acompanhado";
            }
            else
            {
                msgAdicional = "José não está acompanhado";
            }

            if (idade >= 18)
            {
                Console.WriteLine(idade + " anos, maior de idade, pode entrar");
            }
            else if (idade < 18 && acompanhada == true)
            {
                Console.WriteLine(idade + " anos, menor de idade, mas " + msgAdicional + " pode entrar");

            }
            else
            {
                Console.WriteLine(idade + " anos, menor de idade, não pode entrar e " + msgAdicional);
            }

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
