using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    internal class ContaCorrente
    {

        public static int TotalDeContasCriadas { get; private set; }
        private int numeroAgencia;
        private int numero;
        private double _saldo;

        public ContaCorrente(Cliente titular, int numeroAgencia, int numero, double saldo)
        {
            //this.titular.setNome(nome);
            this.numeroAgencia = numeroAgencia;
            this.numero = numero;
            this._saldo = saldo;

            Console.WriteLine("Dados da Conta Bancaria" +
                "\nTitular: " + titular.Nome +
                "\nNúmero da Agência: " + this.numeroAgencia + 
                "\nNúmero: " + this.numero + 
                "\nSaldo R$ " + this._saldo);

            TotalDeContasCriadas++;
        } 
        public double SaldoDaConta()
        {
            return this._saldo;
        }

        public void Depositar(double valor)
        {
            if (valor < 1)
            {
                Console.WriteLine("Valor digitado inválido");
                
            }
            else
            {
                this._saldo += valor;

            }
           
        }

        public void Sacar(double valor)
        {
            if (valor > this._saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this._saldo -= valor;
            }

         
        }

        public void Transferir(double valor, ContaCorrente destinatario)
        {
            if (valor > this._saldo)
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
