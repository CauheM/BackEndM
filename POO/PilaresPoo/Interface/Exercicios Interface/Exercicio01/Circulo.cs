namespace Exercicio01
{
    public class Circulo : IForma
    {
      public float Raio1;
      public float Raio2;
        public void CalcularArea()
        {
          float Resultado = (float)Math.PI * Raio1 * Raio2;
          Console.WriteLine($"O resultado da area do circulo será: {Resultado:F2}");
        }
    }
}