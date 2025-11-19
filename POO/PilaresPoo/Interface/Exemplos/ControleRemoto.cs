namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int Volume;
        public int VolumeMax = 10;


        public void AumentarVolume()
        {
            if (Volume > VolumeMax)
            {
                Console.WriteLine("N é possivel aumentar o volume");
                return;
            }

            Volume++;

            Console.WriteLine($"Volume: {Volume}");
        }

        public void desligar()
        {
            Console.WriteLine("Desligando");
        }

        public void DiminuirVolume()
        {
            if(Volume < 0)
            {
                Console.WriteLine("Não é possivel abaixar o volume");
                return;
            }

            Volume--;

            Console.WriteLine($"Volume: {Volume}");
        }

        public void ligar()
        {
            Console.WriteLine("Ligando");
        }
    }
}