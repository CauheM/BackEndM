// See https://aka.ms/new-console-template for more information

float n1, n2;

Console.WriteLine("Bem vindo a calculadora, escolhe o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("o segundo número");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"o resultado é {n1 + n2}");