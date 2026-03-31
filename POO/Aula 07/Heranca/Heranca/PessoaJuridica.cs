namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {   
        //Campos
        private double limite;

        //Propriedades
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtores
        public PessoaJuridica(int numeroConta, string titularConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Métodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
