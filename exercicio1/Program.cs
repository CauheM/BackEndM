Console.WriteLine("olá, digite o seu salario recebido");
float salariorecebido = float.Parse(Console.ReadLine());

Console.WriteLine("agora digite seus gastos");
float salariogastado = float.Parse(Console.ReadLine());

if (salariorecebido < salariogastado)
{
    Console.WriteLine("orçamento estourado");
}
else
{
     Console.WriteLine("Gastos dentro do orçamento");
}