using Atividade_2511;

Console.Clear();

Carro carro = new Carro();

carro.DefinirMarca("Ford");
carro.DefinirModelo("Raptor");
carro.Acelerar(300);
carro.frear(25);

Console.WriteLine($"Marca do Carro: {carro.ObterMarca()}");
Console.WriteLine($"Modelo do Carro: {carro.ObterModelo()}");
Console.WriteLine($"Velocidade do Carro: {carro.ObterVelocidade()}KM");