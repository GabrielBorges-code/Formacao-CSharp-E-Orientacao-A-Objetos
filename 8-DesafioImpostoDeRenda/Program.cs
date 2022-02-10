using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DesafioImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Desafio Imposto de Renda");

            Console.WriteLine("Por favor, digite seu salário para que possamos calcular o imposto de Renda");
            Console.Write("(somente números) R$ ");
            string renda = Console.ReadLine();

            double rendaConvertida = Convert.ToDouble(renda);

            if (rendaConvertida >= 1900.00 && rendaConvertida <= 2800.00)
            {
                Console.WriteLine("A sua aliquota é de 7,5% \nVocê pode deduzir até R$ 142");
            }
            else if (rendaConvertida >= 2800.01 && rendaConvertida <= 3751.00)
            {
                Console.WriteLine("A sua aliquota é de 15% \nVocê pode deduzir até R$ 350");
            }
            else if (rendaConvertida >= 3751.01 && rendaConvertida <= 4664.00)
            {
                Console.WriteLine("A sua aliquota é de 22,5% \nVocê pode deduzir até R$ 636");
            } 
            else if (rendaConvertida < 1900.00)
            {
                Console.WriteLine("Você não declara Imposto de Renda");
            }



            Console.WriteLine("Execução finalizada. Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}
