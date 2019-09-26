using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {
    
    public string Senha;
      public bool Logar(IAutenticavel funcionario, string senha)
       {
           //logador
           bool UsuarioLogado = funcionario.Autenticar(senha);
            if(UsuarioLogado)
            {
                Console.WriteLine("Logado");
                return true;
            }else{
                System.Console.WriteLine(funcionario.Autenticar(senha));
                Console.WriteLine(senha);
                Console.WriteLine("Senha ou Usuário incorretos");
                return false;
            }
       }
    }
}
