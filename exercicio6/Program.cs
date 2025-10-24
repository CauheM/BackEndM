double media, frequencia;

Console.WriteLine("Digite a média do aluno");
media = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a frequencia do aluno");
frequencia = double.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Situação: REPROVADO por frequencia");
}
else if (media >= 7)
{
    Console.WriteLine("Situação: APROVADO");
}
else if (media >= 3)
{
    Console.WriteLine("Situação: REPROVADO");
}
else
{
    Console.WriteLine("Siruação: REPROVADO por média");
}