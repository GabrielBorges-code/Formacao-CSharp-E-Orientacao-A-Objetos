using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Gabriela Barbosa", "123.456.789.10", 2100.54);
            
            Console.WriteLine(funcionario1.Nome + "\n" +
                funcionario1.CPF + "\n" +
                funcionario1.Salario);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(funcionario1);
            Console.WriteLine("Bonificaçao " + gerenciador.Bonificacao());
           
            Console.WriteLine();

            Gerente genrente1 = new Gerente("Joao Silva", "987.654.321.01", 4000);

            Console.WriteLine(genrente1.Nome + "\n" +
                genrente1.CPF + "\n" +
                genrente1.Salario);

            Console.WriteLine(genrente1.Salario);
            
            gerenciador.Registrar(genrente1);
            Console.WriteLine("Bonificaçao " + gerenciador.Bonificacao());

            Console.ReadLine();
        }
    }
}
