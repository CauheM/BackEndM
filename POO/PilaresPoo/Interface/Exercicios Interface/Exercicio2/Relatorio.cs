namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel = "";
        public string TextoRelatorio = "";

        public Relatorio(string n, string t)
        {
            NomeResponsavel = n;
            TextoRelatorio = t;
        }
        public void Imprimir()
        {
            Console.WriteLine(@$"
Nome do Responsável: {NomeResponsavel}
Texto do Relatório: {TextoRelatorio}
");
        }
    }
}