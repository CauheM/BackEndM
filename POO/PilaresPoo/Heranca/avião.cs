namespace Heranca
{
    public class avião : Veiculo
    {
        public string freiodepouso;
        public void Exibirinfo()
        {

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Freio de pouso: {freiodepouso}");

        }
    }
}