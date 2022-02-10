using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaractereseTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Textos");

            //A variável do char recebe apenas aspas simples
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 7);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura, Cursos de Tecnologia " + 2022;
            Console.WriteLine(titulo);

            string cursosProgramacao = " - Java" +
                "\n - JavaScript" +
                "\n - PHP" +
                "\n - C#";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();

        }
    }
}
