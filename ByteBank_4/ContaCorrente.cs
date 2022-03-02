// using _05_ByteBank;

using System;

namespace ByteBank_2
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia { get; }
        public int Numero { get; }
       

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                ArgumentException ex = new ArgumentException("A Agência deve ser maior que zero", nameof(agencia));

                throw ex; 
            }
            
            if (numero <= 0)
            {
                ArgumentException ex = new ArgumentException("O Número deve ser maior que zero", nameof(numero));

                throw ex;
            }

            Agencia = agencia;
            Numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
