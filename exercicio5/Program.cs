int total;
int quantidade;

Console.WriteLine("olá, digite a senha");
quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    total = quantidade * 0.30;
}
else
{
    total = quantidade * 0.25;
}
Console.WriteLine($"valor total de compra: R$ {total:F2}");