namespace Exercicios2
{
    public class Gerente : Funcionario
    {
        public float bonus;

        public override float CalcularSalario()
        {
            return Salario += bonus;
        }
    }
}