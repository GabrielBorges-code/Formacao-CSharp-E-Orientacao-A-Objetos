using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
