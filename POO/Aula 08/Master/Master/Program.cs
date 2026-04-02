using Master;

Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 12345));

var a = conta.ToString();
Console.WriteLine(a);