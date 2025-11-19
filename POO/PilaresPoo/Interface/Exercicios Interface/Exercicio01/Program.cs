using Exercicio01;

Console.Clear();

Retangulo retangulo = new Retangulo(10, 15);

retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine("--------------");
Console.WriteLine();

Circulo circulo = new Circulo();
circulo.Raio1 = 5;
circulo.Raio2 = 10;

circulo.CalcularArea();