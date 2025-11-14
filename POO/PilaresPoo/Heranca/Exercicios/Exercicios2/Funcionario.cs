namespace Exercicios2
{
    public class Funcionario
    {
        public string Nome;
        public float Salario;

        public virtual float CalcularSalario()
        {
            return Salario;
        }
    }
}