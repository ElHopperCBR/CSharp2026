//Entrada de dados
/*------------------------------------------*/
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();//Entrada de dados 
System.Console.WriteLine($"O valor digitado é de {nome}");
System.Console.WriteLine("Digite o 1° numero: ");
double x = double.Parse(Console.ReadLine()); //Conversão de dados
System.Console.WriteLine("Digite o 2° número: ");
double y = double.Parse(Console.ReadLine()); //Conversão de dados
/*------------------------------------------*/
//Processamento de dados
/*------------------------------------------*/
double soma = x + y;
/*------------------------------------------*/
//Saida de dados
/*------------------------------------------*/
System.Console.WriteLine($"A soma dos dois valores é de {soma}");
/*------------------------------------------*/