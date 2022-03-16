using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string endereco = "R. São Carlos do Pinhal nº746";
            string enderecoFormatado =
                endereco
                    .ToUpper()
                    .Replace("r.", "Rua")
                    .Replace(" nº", ", Número ")
                    .ToUpper();

            Console.WriteLine(enderecoFormatado);

            Console.ReadLine();
        }

       
    }
}
