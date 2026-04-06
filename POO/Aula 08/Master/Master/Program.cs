using Master;

Conta conta = new Conta(12345, 11500.56, new Pessoa("Clodoaldo", 40689710023));

var a = conta.ToString();
Console.WriteLine(a);