﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    internal class Titular
    {
        private string nome;
        private string cpf;
        private string profissao;

        public Titular(string nome, string cpf, string profissao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.profissao = profissao;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getProfissao()
        {
            return this.profissao;
        }

        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }


    }
}
