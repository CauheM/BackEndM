Console.WriteLine("olá, digite os gols do primeiro time");
int t1 = int.Parse(Console.ReadLine());

Console.WriteLine("agora digite os gols do outro time");
int t2 = int.Parse(Console.ReadLine());

if (t1 < t2)
{
    Console.WriteLine("placar final");
    Console.WriteLine("time1   time2");
    Console.WriteLine($"{t1} x {t2}");
    Console.WriteLine("time2 ganhou");
}
else if (t1 == t2)
{
    Console.WriteLine("placar final");
    Console.WriteLine("time1   time2");
    Console.WriteLine($"{t1} x {t2}");
    Console.WriteLine("   EMPATE   ");
}
else
{
    Console.WriteLine("placar final");
    Console.WriteLine("time1   time2");
    Console.WriteLine($"{t1} x {t2}");
    Console.WriteLine("time1 ganhou");
}