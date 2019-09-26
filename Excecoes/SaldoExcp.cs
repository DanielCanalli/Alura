using System;

namespace ByteBank.Excecoes
{
    public class SaldoExcp:Exception
    {
        public double Saldo{get;}
        public double Valor {get;}
        public SaldoExcp()
        {
        }

        public SaldoExcp(double saldo,double valor):this("conta tem saldo de "+saldo+" e valor de saque e"+valor)
        {
            Saldo=saldo;
            Valor=valor;
        }
        public SaldoExcp(string mensagem):base(mensagem)
        {
            Console.WriteLine("Saldo Insuficiente");
        }
    }
}