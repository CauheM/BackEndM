namespace Exercicio01
{
    public class Retangulo : IForma
    {
      public float Altura;
      public float Largura;

      public Retangulo(float A, float L)
        {
            Altura = A;
            Largura = L;
        }

        public void CalcularArea()
        {
          double Resultado = Largura * Altura;
          Console.WriteLine($"O resultado da area do retangulo será: {Resultado:F2}");
        }
    }
}