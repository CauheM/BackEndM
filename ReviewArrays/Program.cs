string nome = "Edu";
string nome2 = "Marcio";
string nome3 = "Manoel";

string[] nomes = new string[4];

nomes[0] = "Edu";
nomes[1] = "Marcio";
nomes[2] = "Manoel";

Console.WriteLine($"Tamanho do Array: {nomes.Length}");

for (int i = 0; i <nomes.Length; i++)
{
    Console.WriteLine($"{i} Nome: {nomes[0]}");
}