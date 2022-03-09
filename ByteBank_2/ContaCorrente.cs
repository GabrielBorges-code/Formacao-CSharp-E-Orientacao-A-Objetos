// using _05_ByteBank;

using System;

namespace ByteBank_2
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
          
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciaNaoPermitidas { get; private set; }


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

            TotalDeContasCriadas++;
            
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque, pois é menor que zero. ", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência, pois é menor que zero. ", nameof(valor));
            }

            //Sacar(valor);

            try
            {
                Sacar(valor);

            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciaNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada!", ex);

            }

            contaDestino.Depositar(valor);
        }
    }
}
