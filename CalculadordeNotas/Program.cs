
string nome;
float n1, n2, n3, n4, resultado;

Console.WriteLine("Olá, qual é seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite sua primeira nota");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua terceira nota");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua quarta nota");
n4 = float.Parse(Console.ReadLine());

resultado = (n1 + n2 + n3 + n4) / 4;

if (resultado >= 7)
{
    Console.WriteLine("você está aprovado");
}
else if (resultado >= 5)
{
    Console.WriteLine("você está de recuperação");
}
else
{
    Console.WriteLine("você está reprovado");
}