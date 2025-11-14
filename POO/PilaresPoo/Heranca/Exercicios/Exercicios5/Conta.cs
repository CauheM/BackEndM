namespace Exercicios5
{
    public class Conta
    {
        public int Numero;
        public double Saldo;
        public void Depositar(double valor)
        {
        Saldo += valor;
        }
        public void Sacar(double valor)
        {
        Saldo -= valor;
        }
    }
}