namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;   
        public int Idade;

         public override void FazerSom()
        {
            Console.WriteLine($"{Nome} - Olá, como vai");
        }

        public override void Mover()
        {
            Console.WriteLine("*caminhando*");
        }
    
        public void Dormir()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZ");
        }
    }
}