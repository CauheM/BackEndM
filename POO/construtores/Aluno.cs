
namespace construtores
{
    public class Aluno
    {
        public string Nome;
        public int Nota;

        public Aluno()
        {
            Console.WriteLine("Lista de Alunos: ");
        }

        public Aluno(string n, int nt)
        {

            Nome = n;
            Nota = nt;

        }

        public void Exibirdados()
        {
            Console.WriteLine($"Aluno: {Nome} Nota: {Nota}");
        }
    }
}