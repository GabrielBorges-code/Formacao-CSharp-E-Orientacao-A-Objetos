using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class GerenciadorBonificacao
    {
        private double _bonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _bonificacao += funcionario.GetBonificacao();
        }       

        public double Bonificacao()
        {
            return _bonificacao;
        }

    }
}
