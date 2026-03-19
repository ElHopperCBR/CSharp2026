using terreno;
using static System.Console;

Write("Digite a largura do terreno: ");
double largura = double.Parse(Console.ReadLine());
Write("Digite o comprimento do terreno: ");
double comprimeto = double.Parse(Console.ReadLine());
Write("Digite o preço do m² do terreno: ");
double valor = double.Parse(Console.ReadLine());

Terreno t = new Terreno(largura, comprimeto, valor);

t.Saida();
ReadKey();
