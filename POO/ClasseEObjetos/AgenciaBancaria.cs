namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public float Depositar;
        public float Sacar;



        public void DepositarDinheiro()
        {
            Console.WriteLine("Quanto vc vai querer depositar");

            Depositar = float.Parse(Console.ReadLine());

            Console.WriteLine($"R$ {Depositar:F2} foi depositado com sucesso");
            Console.ReadLine();

        }
        public void SacarDinheiro()
        {
           Console.Write("Valor para saque: ");
           Sacar = float.Parse(Console.ReadLine());

         if (Sacar <= 0)
        {
          Console.WriteLine("Valor inválido");
          return;
        }
         else if (Sacar > Depositar)
        {
          Console.WriteLine("Saldo insuficiente");
          Console.ReadLine();
        }
        else
        {
        Depositar -= Sacar;
        Console.WriteLine($"Saque de R$ {Sacar:F2} realizado com sucesso");
        Console.WriteLine($"Seu saldo atual: R$ {Depositar:F2}");
        Console.ReadLine();
        }
   
        }
        
    }
}

