using System;
using ByteBank.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor Carlos = new Diretor(23423423,234234);
            SistemaInterno Login = new SistemaInterno();
            Carlos.Senha="fsdmfosd";
            Login.Logar(Carlos,"fisdmfosd");
            Console.WriteLine(Carlos.Senha);
        }
    }
}
