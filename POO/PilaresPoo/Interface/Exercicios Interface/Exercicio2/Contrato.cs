namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Nome = "";
        public string TextoClausulas = "";

        public Contrato(string n, string t)
        {
            Nome = n;
            TextoClausulas = t;
        }
        public void Imprimir()
        {
            Console.WriteLine(@$"
Nome: {Nome}
Texto da Clausula: {TextoClausulas}
");
        }
    }
}