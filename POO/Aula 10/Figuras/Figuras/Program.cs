using static System.Console;
using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeracoes;

List<Forma> formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geométrico n°{i+1}:");
    Write($"Retângulo ou Círculo (R/C): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a cor do objeto? " +
            "\n\t 1 - Vermelho" +
            "\n\t 2 - Azul" +
            "\n\t 3 - Amarelo" +
            "\n\t 4 - Rosa");
        int cor = int.Parse(ReadLine());
        Write("Digite a largura do retângulo: ");
        double l = double.Parse(ReadLine());
        Write("Digite a altura do retângulo: ");
        double a = double.Parse(ReadLine());
        formas.Add(new Retangulo((Cor)cor, l, a));
    }
    else if (escolha == 'c')
    {
        WriteLine("Qual é a cor do objeto? " +
                    "\n\t 1 - Vermelho" +
                    "\n\t 2 - Azul" +
                    "\n\t 3 - Amarelo" +
                    "\n\t 4 - Rosa");
        int cor = int.Parse(ReadLine());
        Write("Digite o raio da circunferencia: ");
        double r = double.Parse(ReadLine());
        formas.Add(new Circulo((Cor)cor, r));
    }
}

foreach (var figurinhas in formas)
{
    Write(figurinhas.ToString() + "\n");
}


