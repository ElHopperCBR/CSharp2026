using static System.Console;
//-----Declaração de um dicionario
Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"João", 20},
    {"Maria", 30},
    {"Pedro", 40}
};
//-----Adiconando dados ao dicionario
pessoas.Add("Clodoaldo", 54);
foreach (var item in pessoas)
{
    WriteLine($"Chave = {item.Key} - Valor = {item.Value}");
}
WriteLine($"Tamanho = {pessoas.Count()}");
WriteLine(pessoas["Clodoaldo"]);
WriteLine($"Tamanho = {pessoas.Count()}");
pessoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pessoas.Count()}");
pessoas.Add("João", 40);
foreach (var item in pessoas)
{
    WriteLine($"Chave = {item.Key} - Valor = {item.Value}");
}