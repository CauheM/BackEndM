using System.Data.Common;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo = 0;

        public ContaCorrente(double saldoinicial)
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

        private double TaxaSaque = 5;
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