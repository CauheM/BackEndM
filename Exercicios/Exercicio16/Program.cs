
string cargo;
float salario;


Console.WriteLine("Olá, qual é seu cargo");
cargo = Console.ReadLine();

Console.WriteLine("Qual é seu salario");
salario = float.Parse(Console.ReadLine());

if (cargo == "produção")
{
    Console.WriteLine($"Seu novo salario é: {salario * 0.065}");
}
else if (cargo == "administrativo")
{
    Console.WriteLine($"Seu novo salario é: {salario * 0.075}");
}
else if (cargo == "diretoria")
{
    Console.WriteLine($"Seu novo salario é: {salario * 0.12}");
}
else
{
    Console.WriteLine("Seu salario não teve alteração");
}