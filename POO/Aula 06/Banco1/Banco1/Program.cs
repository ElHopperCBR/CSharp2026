using Banco1;
using static System.Console;

Title = "Cadastro de conta";
ContaBancaria conta;

//Entrada de dados
Write("Entre com o número da conta: ");
int n = int.Parse(ReadLine());
Write("Entre com o nome do titular da conta: ");
string nome = ReadLine();//string
Write("Deseja fazer depósito inicial (s/n): ");
char resposta  = char.Parse(ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre com o valor de depósito inicial: ");
    double dep = double.Parse(ReadLine());
    conta = new ContaBancaria(n, nome, dep);
}
else
{
    conta = new(n, nome);
}

conta.Dados();
ReadKey();