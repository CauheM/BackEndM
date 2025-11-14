namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;

        public ContaPoupanca(double saldoinicial)
        {
            Saldo = saldoinicial;
        }
        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Saldo += valor;
        }

        private double TaxaSaque = 3;
        public override void Sacar(double valor)
        {

         double totalcomtaxa = (valor / 100 * TaxaSaque) + valor;

         if(valor <= 0 || Saldo >= totalcomtaxa)
         {
           Console.WriteLine("valor invalido ou insuficiencia de dinheiro");
           return;
         }

         Saldo -= totalcomtaxa;

        }

    }
}