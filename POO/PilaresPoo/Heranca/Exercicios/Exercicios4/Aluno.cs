namespace Exercicios4
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }
}