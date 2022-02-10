using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EscopoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção de 1 a 5");
            string valorDigitado = Console.ReadLine();

            switch (valorDigitado)
            {
                case "1":
                    Console.WriteLine("Escolheu a opção 1");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Escolheu a opção 2");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Escolheu a opção 3");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Escolheu a opção 4");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Escolheu a opção 5");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Valor digitado inválido");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("Tecle ENTER para sair.");
            Console.WriteLine();

        }
    }
}
