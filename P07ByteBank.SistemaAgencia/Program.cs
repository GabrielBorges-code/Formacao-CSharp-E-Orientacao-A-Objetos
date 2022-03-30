using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace P07ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            
            idades[0] = 30;
            idades[1] = 24;
            idades[2] = 55;
            idades[3] = 21;
            idades[4] = 15;

            int recebeValor = idades[1];
            int somaIdades = 0;
            
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine($"indice: {i} - {idades[i]} anos de idade");
                somaIdades += idades[i]; 
            }

            int mediaIdades = somaIdades / idades.Length;

            Console.WriteLine($"Média das idades {mediaIdades}");

            int[] outroArray = idades;

            Console.WriteLine("\n" + outroArray[2]);

            //string[] palavras = new string["Palavra", "Outra expressão"];
            Console.WriteLine("\n\n");

            int[] arrayDeIdades = new int[] { 25, 26, 27, 35, 15, 10 }; //outra forma de escrever um array

            for (int i = 0; i < arrayDeIdades.Length; i++)
            {
                Console.WriteLine($"indice: {i} - {arrayDeIdades[i]} anos de idade");

            }

            Console.ReadLine();
        }

        public static void outroArray()
        {
           ContaCorrente[] contas = new ContaCorrente[]
           {
               new ContaCorrente(3218, 8765),
               new ContaCorrente(3217, 9874),
               new ContaCorrente(3216, 5412)
           };


            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"{i + 1} - Nº da conta: {contas[i].Numero}, Agência da conta: {contas[i].Agencia}");
            }
        }
    }
}
