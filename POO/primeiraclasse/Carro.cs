

namespace primeiraclasse
{
    public class Carro
    {
        public string modelo;
        public string marca;
        public string cor;
        public string potencia;

        public void Ligar()
        {
            Console.WriteLine("Ligando em 3, 2, 1, ... vrum!");
        }

        public void acelerar()
        {
            Console.WriteLine("Vrum, Vrum");
        }
    }
}