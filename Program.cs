using System;
using ByteBank.ContaCorrente;
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
            object Anderson = new CCorrente(5454654,456468);
            string ContaString = Anderson.ToString();
            System.Console.WriteLine(ContaString);
            
        }
    }
}
