using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
 
            //CalcularBonificacao();
            UsarSistema();

            Console.WriteLine("\n\nQuantidade de contas criadas " + Funcionario.QtdContasCriadas);

            Console.ReadLine();
            
        }

        public static void UsarSistema()
        {
            Diretor diretor2 = new Diretor("Regina Sousa", "654.852.117-98", 4000);
            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("Paula Bueno", "741.852.963-65", 4000.00);
            ParceiroComercial parceiroComercial = new ParceiroComercial();
            SistemaInterno sistema = new SistemaInterno();

            diretor2.Senha = "4321";
            gerenteDeConta1.Senha = "Ab12";
            parceiroComercial.Senha = "@321";

            sistema.Logar(diretor2, "4321");
            sistema.Logar(gerenteDeConta1, "4321");
            sistema.Logar(parceiroComercial, "@321");

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Diretor diretor1 = new Diretor("Joao Silva", "987.654.321.01", 4000);
            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("Paula Bueno", "741.852.963-65", 4000.00);
            Designer designer1 = new Designer("Jose Neto", "963.825.741.01", 3000.00);
            Auxiliar auxiliar1 = new Auxiliar("Francisneide Aldaberto", "852.456.987.14", 2000.00);
            Funcionario desenvolvedor = new Desenvolvedor("Gabriel Borges", "987.456.312.12", 5500.00);

            gerenciadorBonificacao.Registrar(diretor1);
            gerenciadorBonificacao.Registrar(gerenteDeConta1);
            gerenciadorBonificacao.Registrar(designer1);
            gerenciadorBonificacao.Registrar(auxiliar1);
            gerenciadorBonificacao.Registrar(desenvolvedor);

            Console.WriteLine("\nTotal em Bonificação R$ " + gerenciadorBonificacao.Bonificacao());

        }
    }
}
