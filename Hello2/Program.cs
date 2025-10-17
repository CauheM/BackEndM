// See https://aka.ms/new-console-template for more information

string nomedofulano;
string sobrenomedofulano;
int Idade;
float saldobancario;
float investimentos;

Console.WriteLine("Olá, qual é seu nome");
nomedofulano = Console.ReadLine();

Console.WriteLine("qual é seu sobrenome");
sobrenomedofulano = Console.ReadLine();

Console.WriteLine("qual é sua idade");
Idade = int.Parse(Console.ReadLine());

Console.WriteLine("qual é sua seu saldo");
saldobancario = float.Parse(Console.ReadLine());

Console.WriteLine("qual é seus investimentos");
investimentos = float.Parse(Console.ReadLine());

Console.WriteLine($"Nome: {nomedofulano} {sobrenomedofulano}");
Console.WriteLine($"a Idade do(a) {nomedofulano} é: {Idade}");
Console.WriteLine($"Saldo: {saldobancario}");
Console.WriteLine($"Investimento este ano: {investimentos}");


Console.Clear();