using Exercicios2;

Funcionario fun = new Funcionario();
Gerente Ronaldo = new Gerente();

fun.Salario = 1000;
Ronaldo.Salario = 1000;

float SalFinal = fun.CalcularSalario();
float SalFinalG = Ronaldo.CalcularSalario();

Console.WriteLine($"Salario do Funcionario: {SalFinal}");
Console.WriteLine($"Salario do Gerente: {SalFinalG}");