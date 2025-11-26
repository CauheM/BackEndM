using ClassesEstaticas;

Console.Clear();

//Console.WriteLine($"Número do PI: {CalculosMatematicos.PI}");

Console.WriteLine("Escolha um número");
CalculosMatematicos.x = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha outro um número");
CalculosMatematicos.y = int.Parse(Console.ReadLine());

Console.WriteLine(@"Escolha uma das opções:
1 - Somar
2 - Subtrair 
3 - Dividir 
4 - Multiplicar
5 - Maior e Menor");
Console.Write("Escolha uma opção: ");
int opção = int.Parse(Console.ReadLine());

switch (opção)
{
    case 1:
    CalculosMatematicos.Somar();
    break;
    case 2:
    CalculosMatematicos.Menos();
    break;
    case 3:
    CalculosMatematicos.Dividir();
    break;
    case 4:
    CalculosMatematicos.Multiplicar();
    break;
    case 5:
    CalculosMatematicos.MaiorouMenor();
    break;
    default:
    Console.WriteLine("opção inválida");
    return;
    break;
}