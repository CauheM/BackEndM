int contador = 1;

Console.WriteLine("Quantos números você quer digitar");
int qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{

Console.WriteLine("Escolhe um número");
int barneythebigmac = int.Parse(Console.ReadLine());

    if (barneythebigmac %2 == 0)
    {
        Console.WriteLine($"o número {barneythebigmac} é par");
    }

     contador++;
    
}