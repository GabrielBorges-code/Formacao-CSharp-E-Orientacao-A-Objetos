using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variáveis Com Ponto Flutuante");

            double salario = 1200.76;

            Console.WriteLine("Salário do funcionário " + salario);

            double divisao = 27.0 / 4;

            Console.WriteLine("27 / 4 = " + divisao);

            double divisao2 = 5.0 / 3;

            Console.WriteLine("5 / 3 = " + divisao2); 

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
