namespace Heranca
{
    internal class PessoaFisica
    {
        //Campo
        private int numero;
        private string titular;
        private double saldo;

        //Propriedades
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor
        public PessoaFisica(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }
        public PessoaFisica(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        //Métodos
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente: " +
                $"\n\t Número da conta: {NumeroConta}" +
                $"\n\t Titular da conta: {TitularConta}" +
                $"\n\t Saldo da conta: {SaldoConta:C}";
        }
    }
}
