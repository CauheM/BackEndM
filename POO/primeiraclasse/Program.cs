
using primeiraclasse;

Pessoa Ronaldo = new Pessoa();
Ronaldo.nome = "Ronaldo";
Ronaldo.idade = 41;
Ronaldo.altura = 179;

Console.WriteLine($"{Ronaldo.nome} tem {Ronaldo.idade}");
Ronaldo.Envelhecer(10);
Console.WriteLine($"{Ronaldo.nome} tem {Ronaldo.idade}");