namespace encapsulamento
{
    public class ContaBancaria
    {
      private float saldo;

      public ContaBancaria()
        {
            saldo = 0;
        }   
      public ContaBancaria(float saldoinicial)
        {
            saldo = saldoinicial;
        }

      public void Depositar(float Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                saldo += Valor;
            }
        }        

        public float GetSaldo()
        {
            return saldo;
        }
      public void Sacar(float Valor)
        {
            if (Valor >= 0 && Valor <= saldo)
            {
                saldo -= Valor;
            }
            else 
            {
               Console.WriteLine("Valor inválido");
            }
        }  
    }
}