using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Carlos Roberto";
            cliente1.CPF = "587.985.654-20";
            cliente1.Profissao = "Developer";

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Carlos Roberto";
            cliente2.CPF = "587.985.654-20";
            cliente2.Profissao = "Developer";

            Console.WriteLine(cliente1 == cliente2);

            Console.ReadLine();

            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Gabriel Borges, meu telefone (61) 98888-4444.";
                
            string padraoCPF = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";
            string textoDeTeste2 = "Meu CPF é 065.987.123-12";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Match resultadoCPF = Regex.Match(textoDeTeste2, padraoCPF);

            Console.WriteLine("Telefone: " + resultado);
            Console.WriteLine("CPF: " + resultadoCPF);

            Console.WriteLine($"escrevendo variavel textoDeTeste2: \n{textoDeTeste2}");

            Console.ReadLine();

        }
    }
}
