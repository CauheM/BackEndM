namespace construtores
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string n, double p, int e)
        {

            Nome = n;
            Preco = p;
            Estoque = e;

        }

        public void Exibirdados()
        {
            Console.WriteLine($"Nome do produto: {Nome} Preço: {Preco:F2} Estoque: {Estoque}");
        }
    }
}