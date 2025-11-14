namespace Heranca
{
    public class Gerente : Funcionario
    {

        public double Bonus;


        public Gerente(string nome, double salarioBase, double bonus)
            : base(nome, salarioBase)
        {
            Bonus = bonus;
        }

        public double CalcularSalario()
        {
            return Salario + Bonus;
        }

    }   
        
    }
