namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;
        public void Exibirinfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantidade de portas: {QtdPortas}");

        }
    }
}