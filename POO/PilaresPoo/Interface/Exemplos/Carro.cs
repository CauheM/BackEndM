namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;
        
        public Carro(string c, string m, string md, int a)
        {
           Cor = c;
           Marca = m;
           Modelo = md;
           Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informações do Veículo:
            Marca:{Marca}
            Ano:{Ano}
            Modelo:{Modelo}
            Cor:{Cor}
            ");
        }
        public void acelerar()
        {
            Console.WriteLine("vrum");
        }

        public void frear()
        {
             Console.WriteLine("irrrrrrrrrrr");
        }
    }
}