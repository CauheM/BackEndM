namespace Calculadora
{
    public class Calculator
    {

        public int N1;
        public int N2;
        public double Resultado;


        public double Somar()
        {

            Resultado = N1 + N2;
            Console.WriteLine($"Resultado será: {Resultado}");
            return Resultado;          

        }
        public double Diminuir()
        {

            Resultado = N1 - N2;
            Console.WriteLine($"Resultado será: {Resultado}");
            return Resultado;            

        }
        public double Multiplicar()
        {

            Resultado = N1 * N2;
            Console.WriteLine($"Resultado será: {Resultado}");
            return Resultado;

        }
        public double Subtrair()
        {
            if(N2 == 0)
            {
                Console.WriteLine("Não existe divisão por zero");
                return -1;
            }
   
            Resultado = N1 / N2;
            Console.WriteLine($"Resultado será: {Resultado}");
            return Resultado;

        }

    }
    
}