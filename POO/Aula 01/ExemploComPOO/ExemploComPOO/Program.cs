using ExemploComPOO;
using static System.Console;
//Instanciação dos triangulos X e Y
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();
//Entrada de dados
WriteLine("Digite as medidas do triangulo X");
Write("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as medidas do triangulo Y");
Write("Digite a medida A: ");
y.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
y.ladoB= double.Parse(ReadLine());
Write("Digite a medida C: ");
y.ladoC= double.Parse(ReadLine());

//Saída de dados
WriteLine($"A área do triangulo X é de {x.Area()}");
WriteLine($"A área do triangulo Y é de {y.Area()}");
ReadKey();

