Console.WriteLine("digite um lado do triangulo");
int l1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite outro lado do triangulo");
int l2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite mais um lado do triangulo");
int l3 = int.Parse(Console.ReadLine());

if (l1 == l2 && l2 == l3)
{
    Console.WriteLine("esse triangulo é Equilátero");
}
else if (l1 == l2 && l2 > l3)
{
    Console.WriteLine("esse triangulo é Isósceles");
}
else if (l1 > l2 && l2 == l3)
{
    Console.WriteLine("esse triangulo é Isósceles");
}
else
{
    Console.WriteLine("esse triangulo é Escaleno");
}