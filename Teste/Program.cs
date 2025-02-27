﻿//using ByteBank_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possivel dividir por zero");
            }

            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);      
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
                //Console.WriteLine("Esse ´código não é executado"); // código inacessivel
            }
        }
    }
}

