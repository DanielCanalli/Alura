using System;
using ByteBank.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank.Funcionarios
{
    public class Diretor : UsuarioAutenticavel  
    {
        public Diretor(long cpf,double salario):base(cpf,salario){

        }


        public override double GetBonificacao()
        {  
            return Salario*0.5;
        }
    }
}