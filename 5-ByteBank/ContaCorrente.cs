using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    internal class ContaCorrente
    {
        private Titular titular;
        private int numeroAgencia;
        private int numero;
        private double saldo;

        public ContaCorrente(Titular titular, int numeroAgencia, int numero, double saldo)
        {
            //this.titular.setNome(nome);
            this.numeroAgencia = numeroAgencia;
            this.numero = numero;
            this.saldo = saldo;

            Console.WriteLine("Dados da Conta Bancaria" +
                "\nTitular: " + titular.getNome() +
                "\nNúmero da Agência: " + this.numeroAgencia + 
                "\nNúmero: " + this.numero + 
                "\nSaldo R$ " + this.saldo);
        }

        public double SaldoDaConta()
        {
            return this.saldo;
        }

        public void Depositar(double valor)
        {
            if (valor < 1)
            {
                Console.WriteLine("Valor digitado inválido");
                
            }
            else
            {
                this.saldo += valor;

            }
           
        }

        public void Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this.saldo -= valor;
            }

         
        }

        public void Transferir(double valor, ContaCorrente destinatario)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                Sacar(valor);
                destinatario.Depositar(valor);

            }
        }


    }
}
