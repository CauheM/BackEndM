namespace ClasseEObjetos
{
    public class ProdutocomDesconto
    {
        public string nome;
        public float preco;

        public void AplicarDesconto(double percentual = 0)

        {
            Console.WriteLine($"Qual desconto vc irá colocar no {nome}");
            percentual = double.Parse(Console.ReadLine());

            if (percentual <= 0 || percentual > 100)
            {
                Console.WriteLine("Percentual de desconto inválido!");
                return;
            }

            double desconto = preco * (percentual / 100);
            double RF = preco - desconto;

            Console.WriteLine($"Desconto de {percentual}% aplicado, o novo preço será R$ {RF:F2}");

        }
      
    }




    }
