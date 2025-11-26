namespace Atividade_2511
{
    public static class Carro
    {
        private static string Marca;
        private static string Modelo;
        private static int VelocidadeAtual = 0;

        public static void DefinirMarca(string Valor)
        {
            Marca = Valor;
        }

        public string ObterMarca()
        {
            return Marca;   
        }
        public static void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        public static void ObterModelo()
        {
            Console.WriteLine($"Modelo do Carro: {Modelo}");
        }
        public static void ObterVelocidade()
        {
           Console.WriteLine($"Velocidade atual: {VelocidadeAtual}");   
        }
        public static void Acelerar(int Valor)
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
        public static void frear(int Valor)
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