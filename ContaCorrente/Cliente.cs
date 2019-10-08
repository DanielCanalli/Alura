using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private int v1;
        private int v2;

        public Cliente(string Nome, string CPF)
        {
            Nome = _nome;
            CPF = _cpf;
        }

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        
    }
}
