namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string d, string c, float v, int da)
        {

            Devedor = d;
            Credor = c;
            Valor = v;
            DiasAtraso = da;

        }

        public void CalcularValorDivida()
        {
            if(DiasAtraso > 0)
            {
                Valor = Valor + DiasAtraso * Juros;
            }

            if (DiasAtraso >= 5)
            {
                Console.WriteLine("Dívida encaminhada para o SERASA");
            }
        }

        public void Imprimir()
        {
            CalcularValorDivida();

            Console.WriteLine($@"
Credor: {Credor}
Devedor: {Devedor}
Dias de atraso: {DiasAtraso}
Júros: R${Juros * DiasAtraso}
Valor Total: R${Valor:F2}");
        }
    }
}