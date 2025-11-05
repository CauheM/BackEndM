namespace construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void Exibirdados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

        }
    }
}