int numero;

Console.WriteLine("Olá, digite um numero");
numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Números impares até {numero}:");

for (int t = 1; t <= numero; t += 2)
{
    Console.Write($"{t}, ");
}

Console.WriteLine();

Console.WriteLine($"Números pares até {numero}:");

for (int t = 0; t <= numero; t += 2)
{
    Console.Write($"{t}, ");
}