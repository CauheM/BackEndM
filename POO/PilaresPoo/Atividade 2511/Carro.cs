namespace Atividade_2511
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual = 0;

        public void DefinirMarca(string Valor)
        {
            Marca = Valor;
        }

         public string ObterMarca()
         {
           return Marca;
         }
        public  void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        public string ObterModelo()
        {
            return Modelo;
        }
        public int ObterVelocidade()
        {
           return VelocidadeAtual;   
        }
        public void Acelerar(int Valor)
        {
            if (Valor <= VelocidadeAtual)
            {
                Console.WriteLine("Aceleração inválida");
            }
            else
            {
                VelocidadeAtual = Valor;
            }
        }
        public void frear(int Valor)
        {
            if(Valor >= VelocidadeAtual)
            {
                Console.WriteLine("freio inválido");
            }
            else
            {
                VelocidadeAtual -= Valor;
            }
        }

    }
}