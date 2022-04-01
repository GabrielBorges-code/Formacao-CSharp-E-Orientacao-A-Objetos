using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
//using ByteBank.SistemaAgencia;

namespace P07ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista<int> idade = new Lista<int>();

            idade.Adicionar(7);
            idade.Adicionar(4);
            idade.Adicionar(10);
            idade.AdicionarVarios(11, 15, 3, 8);

            int idadeSoma = 0;
            for (int i = 0; i < idade.Tamanho; i++)
            {
                int idadeAtual = idade[i];
                idadeSoma += idadeAtual;    
                Console.WriteLine(idadeAtual);
            }

            int idadeMedia = idadeSoma / idade.Tamanho;

            Console.WriteLine($"idade total {idadeSoma}, idade média {idadeMedia}");

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(7);
            listaDeIdades.Adicionar(8);
            listaDeIdades.Adicionar(8);
            listaDeIdades.AdicionarVarios(10, 16, 23, 15, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];

                Console.WriteLine($"Idade no índice {i}: {idade}");
            }

        }
        static void TestaListaDeContaCorrente()
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contadoGui = new ContaCorrente(9999999, 222222);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contadoGui,
                new ContaCorrente(9874, 36984),
                new ContaCorrente(9873, 87464)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contadoGui,
                new ContaCorrente(9875, 98723),
                new ContaCorrente(8875, 96321),
                new ContaCorrente(7453, 98874)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero} e {itemAtual.Agencia}");
            }


        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaContaArray()
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

        static void VariosArrays()
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
        }
    }
}
