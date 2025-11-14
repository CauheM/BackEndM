namespace Heranca
{
    public class Motoca : Veiculo
    {
        public int QtdPessoas;
        public void Exibirinfo()
        {

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"quantidade de pessoas: {QtdPessoas}");

        }
        
    }
}