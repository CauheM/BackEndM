namespace Exercicios5
{
    public class ContaPoupanca : Conta
    {
      public void CalcularRendimento()
      {
          Saldo += Saldo * 0.02;
      }

    }
}