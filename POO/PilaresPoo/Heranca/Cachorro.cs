
namespace Heranca
{
    public class Cachorro : Animal
    {
        public void Exibirinfo()
        {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Raça: {Raca}");
        Console.WriteLine($"Peso: {Peso}");    
        }
       public void FazerSom()
        {
        Console.WriteLine("AU AU");
        }
    }
}