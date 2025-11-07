namespace construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string n, int i, string xpto)
        {
            
            Nome = n;
            Idade = i;
            Console.WriteLine($"Seu texto é: {xpto}");

        }
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public Pessoa (string n)
        {
            Nome = n;

        }

        public void Exibirdados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

        }
    }
}