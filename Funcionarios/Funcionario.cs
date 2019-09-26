namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        
        public static int TotaldeFuncionarios;
        public string Nome { get; set; }   
        public double Salario { get; set; }
        public long CPF { get; set; }

        public Funcionario(long cpf,double salario){
            Salario=salario;
            CPF=cpf;
            TotaldeFuncionarios++;
        }

        public abstract double GetBonificacao();

    }
}