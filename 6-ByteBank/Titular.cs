using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    internal class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        
        public Titular(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Profissao = profissao;
        }

    }
}
