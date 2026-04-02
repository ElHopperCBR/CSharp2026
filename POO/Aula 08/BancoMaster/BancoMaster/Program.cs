using BancoMaster;
using static System.Console;

WriteLine("Escolha qual conta deseja abrir:\n" +
    "\t1 - Conta comum\n" +
    "\t2 - Conta poupança\n" +
    "\t3 - Conta empresa");

int opcao = int.Parse(ReadLine());

switch (opcao)
{
    case 1:
        Conta conta;
        Write("Digite o titular da conta: ");
        string titular = ReadLine();
        Write("Digite o número da conta: ");
        int numero = int.Parse(ReadLine());
        Write("Deseja fazer depósito inicial (s/n): ");
        char escolha = char.Parse(ReadLine().ToLower());
        if (escolha == 's')
        {
            Write("Digite o depósito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero,titular, deposito);
        }
        else
        {
            conta = new Conta(numero,titular);
        }
        break;
}

ReadKey();