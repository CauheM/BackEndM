string[]  nomes = new string[3];
int[] idade = new int[3];
int totalaluno = 0;
int opcao = -1;
do
{
    Console.Clear();
    Console.WriteLine("==== Aplicativo Sala de Aula ====");
    Console.WriteLine("==== 1- Listar Alunos ====");
    Console.WriteLine("==== 2- Cadastrar alunos ====");
    Console.WriteLine("==== 0- Sair ====");
    Console.WriteLine("==== Escolha uma opção ====");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            ListarAlunos();
            break;

        case 2:
            CadastrarAlunos();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }

} while (opcao != 0);



void ListarAlunos()
{
    Console.WriteLine("== Listagem de aluno ==");
    for (int t = 0; t < totalaluno; t++)
    {
        Console.WriteLine($"{t} nome - {nomes[t]} idade - {idade[t]}");
    }
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
    return;
}

void CadastrarAlunos()
{
        Console.WriteLine("== Cadastro de aluno ==");
    
     if (totalaluno >= 3)
    {
        Console.WriteLine("Limite de vagas atingido");
        Console.WriteLine("Digite <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("Digite o nome do aluno");
    nomes[totalaluno] = Console.ReadLine();

     Console.WriteLine("Digite a idade do aluno");
    idade[totalaluno] = int.Parse(Console.ReadLine());

    totalaluno++;

    Console.WriteLine("Aluno cadastrado com sucesso, digite <enter> para continuar");
    Console.ReadLine();
    return;
}
