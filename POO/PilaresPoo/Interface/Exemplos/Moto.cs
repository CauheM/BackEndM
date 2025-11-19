
namespace Exemplos
{
    public class Moto : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Moto(string c, string m, string md, int a)
        {
           Cor = c;
           Marca = m;
           Modelo = md;
           Ano = a;
        }

        public void acelerar()
        {
            Console.WriteLine("bibibibibibiib");
        }

        public void frear()
        {
            Console.WriteLine("riririririri ");
        }
    }
}