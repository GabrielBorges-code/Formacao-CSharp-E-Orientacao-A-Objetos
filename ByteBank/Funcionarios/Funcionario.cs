using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //public string Profissao { get; set; }

        public Funcionario (string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
        }

        public virtual double GetBonificacao()
        {
            //return Salario = (Salario * 0.10) + Salario;
            return Salario *=  0.10;
        }


    }
}
