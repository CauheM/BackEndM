int contador = 1;

Console.WriteLine($"Quantas vezes você quer rodar o while");

int qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{
    Console.WriteLine($"Contador é: {contador}");
    contador++;
}