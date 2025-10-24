int opcao = -1;

do
{

    Console.Clear();
    Console.WriteLine($"--------------------------------------");

    Console.WriteLine($"             Bem vindo                ");

    Console.WriteLine($"                 ao                   ");

    Console.WriteLine($"           Jacareca Food              ");

    Console.WriteLine($"--------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("------------------------");
    Console.WriteLine("Escolha uma opção abaixo");
    Console.WriteLine("------------------------");
    Console.WriteLine("      1-Hot holl        ");
    Console.WriteLine("------------------------");
    Console.WriteLine("       2-Guioza         ");
    Console.WriteLine("------------------------");
    Console.WriteLine("       3-Shimeji        ");
    Console.WriteLine("------------------------");
    Console.WriteLine("         0-Sair         ");
    Console.WriteLine("------------------------");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Saindo ...");
            break;

        case 1:
            opcao1();
            break;

        case 2:
            opcao2();
            break;

        case 3:
            opcao3();
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
    Console.Clear();
} while (opcao != 0);





void opcao1()
{
    Console.WriteLine("Boa escolha, estamos preparando o seu Hot holl");
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void opcao2()
{
    Console.WriteLine("Excelente, estamos preparando o seu Guioza");
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void opcao3()
{
    Console.WriteLine("Otimo, estamos preparando o seu Shimeji");
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}