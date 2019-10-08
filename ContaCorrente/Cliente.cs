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

        public Cliente(string Nome, string CPF)
        {
            _nome = Nome;
            _cpf = CPF;
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

        public override bool Equals(object obj)
        {

            Cliente OutroCliente =(Cliente)obj;
            
            return
                _nome == OutroCliente._nome &&
                _cpf ==  OutroCliente._cpf;
        }
    }
}
