using System;
using ByteBank.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank.Funcionarios
{
    public abstract class UsuarioAutenticavel:Funcionario,IAutenticavel
    {

    public string Senha{get;set;}

    public UsuarioAutenticavel(long cpf,double salario):base(cpf,salario){
        System.Console.WriteLine(Senha);
        }

    public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}