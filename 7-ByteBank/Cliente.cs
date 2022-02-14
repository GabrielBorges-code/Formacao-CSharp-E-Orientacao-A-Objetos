using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Profissao = profissao;
        }

    }
}
