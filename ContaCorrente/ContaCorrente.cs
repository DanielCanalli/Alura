// using _05_ByteBank;
using System;
using ByteBank.Excecoes;

namespace ByteBank.ContaCorrente
{
    public class CCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        private int Agencia{get;}
        private int Conta {get;}

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


        public override string ToString()
        {
            return "Agencia " + Agencia + " Conta " + Conta;
        }
        public CCorrente(int agencia, int conta)
        {
            if(agencia <= 0)
        {
            throw new ArgumentException("Agencia igual a zero",nameof(agencia));            
        }
            if(conta <= 0)
        {
            throw new ArgumentException("Conta igual a zero",nameof(conta));            
        }
            Agencia = agencia;
            Conta = conta;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor de Saque invalido",nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoExcp();
            }
            _saldo -= valor;
            Console.WriteLine(_saldo);
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, CCorrente contaDestino)
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
