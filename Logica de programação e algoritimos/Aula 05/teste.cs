int diasDigitados = int.TryParse(Console.ReadLine());
if (int.TryParse(Console.ReadLine(), out diasDigitados))
{
    int anos = diasDigitados / 365;
    int meses = (diasDigitados % 365) / 30;
    int dias = (diasDigitados % 365) % 30;
}
else
{
    Console.WriteLine("Valor digitado é inválido");
}


