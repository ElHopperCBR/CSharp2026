using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = "Calculaora 03";
//Entrada de dados
Write("Digite o raio da circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Saída de dados
WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
Write($"PI: {PI}");
;
