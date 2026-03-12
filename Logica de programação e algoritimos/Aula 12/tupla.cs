//Tupla
var clodoaldo = (34, 34, "Heitor", "SENAI", 'B');

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item2}");
System.Console.WriteLine($"Nome do filho do clodo: {clodoaldo.Item3}");
clodoaldo.Item1 = 54;
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");

(int, int , int) numeros = (1 , 2 , 5);

System.Console.WriteLine($"Números: {numeros.Item1}, {numeros.Item2}, {numeros.Item3}");
