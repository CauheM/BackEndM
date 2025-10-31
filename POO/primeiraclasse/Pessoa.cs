

namespace primeiraclasse
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;



        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {nome}");
        }

        public void Dormir()
        {
            Console.WriteLine("..zzzzzz");
        }

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                idade += _id;
            }
            else
            {
                idade++;
            }
        }
    }
}