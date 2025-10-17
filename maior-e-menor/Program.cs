// See https://aka.ms/new-console-template for more information
float n1, n2;

Console.WriteLine("escolhe um número");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("escolhe mais um número");
n2 = float.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"{n1} é maior que o {n2}");
}
else if (n1 == n2)
{
    Console.WriteLine($"os números que vc escolheu são iguais");
}
else
{
    Console.WriteLine($"{n2} é maior que o {n1}");
}