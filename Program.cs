using System.Reflection;
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
            Cliente Anderson = new Cliente("Anderson MAfmld","4564654456");
            string ContaString = Anderson.ToString();
            System.Console.WriteLine(ContaString);
            Cliente Wandernelson = new Cliente("Anderson MAfmld","4564654456");    
            Console.WriteLine(Anderson.Equals(Wandernelson));

        }
    }
}
