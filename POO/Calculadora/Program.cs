using Calculadora;

Calculator Calc = new Calculator();

int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("== Calculadora ==");
    Console.WriteLine("== Bem vindo a calculadora, escolha uma das opções ==");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Diminuir");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Subtrair");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("Escolha o primeiro número");
    Calc.N1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Escolha o segundo número");
    Calc.N2 = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            Console.WriteLine($"Primeiro Número: {Calc.N1}");
            Console.WriteLine($"Segundo Número: {Calc.N2}");
            Console.WriteLine();

            Calc.Somar();
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine($"Primeiro Número: {Calc.N1}");
            Console.WriteLine($"Segundo Número: {Calc.N2}");
            Console.WriteLine();

            Calc.Diminuir();
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine($"Primeiro Número: {Calc.N1}");
            Console.WriteLine($"Segundo Número: {Calc.N2}");
            Console.WriteLine();

            Calc.Multiplicar();
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine($"Primeiro Número: {Calc.N1}");
            Console.WriteLine($"Segundo Número: {Calc.N2}");
            Console.WriteLine();

            Calc.Subtrair();
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("opção invalida");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;


    }
} while (opcao != 0);

