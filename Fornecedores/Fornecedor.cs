using ByteBank.Sistema;

namespace ByteBank.Fornecedores
{
    public class Fornecedor:IAutenticavel
    {
        public string Senha { get; set; }


        public bool Autenticar(string senha)
        {
            Senha = senha;
            return true;
        }
    }
}