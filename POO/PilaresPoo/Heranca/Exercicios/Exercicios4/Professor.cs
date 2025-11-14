namespace Exercicios4
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }
}