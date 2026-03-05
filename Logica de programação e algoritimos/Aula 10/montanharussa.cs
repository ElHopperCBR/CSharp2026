using static System.Console;
using static System.Linq.Enumerable;
//Declração de variaveis
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, alturas = 0;
try{    
    //Entradad de dados
    Write("Digite o número de visitantes: ");
    visitantes = int.Parse(ReadLine());
    Write("Digite a altura máxima: ");
    altura_max = double.Parse(ReadLine());
    Write("Digite a altura mínima: ");
    altura_min = double.Parse(ReadLine());
    //Processamento de dados
    foreach (int i in Range(0, visitantes))
    {   
        Write($"Digite a altura da pessoa n° {i+1}: ");
        alturas = int.Parse(ReadLine());
        if ((alturas >= altura_min) & (alturas <= altura_max))
        {
            contagem++;
            WriteLine("Pessoa pode entrar no parque");
        }
    }
    WriteLine($"O número de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Valor invalido, digite numerais, Erro = {ex.Message}");
}