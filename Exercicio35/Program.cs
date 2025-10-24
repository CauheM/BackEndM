int contador = 1;

Console.WriteLine("Quantas vezes você quer repetir");
int qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{

Console.WriteLine("Escolhe um número");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escolhe outro número");
int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"{n1} é maior que {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"{n2} é maior que {n1}");
    }
    else
    {
        Console.WriteLine("ambos são iguais");
    }

    contador++;

}