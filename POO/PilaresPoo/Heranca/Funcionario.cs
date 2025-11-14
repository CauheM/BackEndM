namespace Heranca
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public double CalcularSalario()
        {
            return Salario;
        }
    
    }
}