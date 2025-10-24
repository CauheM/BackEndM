string[] nomes = new string[10];
float[] dinheiro = new float[10];
int totalclientes = 0;
float totaldinheiro = 0;
int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("==== Agencia do VSFN ====");
    Console.WriteLine("==== 1- Cadastrar Cliente ====");
    Console.WriteLine("==== 2- Depositar ====");
    Console.WriteLine("==== 3- Sacar ====");
    Console.WriteLine("==== 4- Transferir ====");
    Console.WriteLine("==== 5- Listar clientes ====");
    Console.WriteLine("==== 0- Sair ====");
    Console.WriteLine("==== Escolha uma opção ====");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            CadastrarClientes();
            break;

        case 2:
            Depositardinheiro();
            break;

        case 3:
            SacarDinheiro(); 
            break;
 
        case 4:
            TransferirDinheiro();
            break;        
            
        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine("Opção Invalida");
            break;
    }




} while (opcao != 0);

void CadastrarClientes()
{
    Console.WriteLine("== Cadastro do cliente ==");

    if (totalclientes >= 10)
    {
        Console.WriteLine("Limite de cadastros atingido");
        Console.WriteLine("Digite <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("Digite o nome do cliente");
    nomes[totalclientes] = Console.ReadLine();
    
    dinheiro[totalclientes] = 0;

    totalclientes++;
    

    Console.WriteLine("Cliente cadastrado com sucesso, digite <enter> para continuar");
    Console.ReadLine();
    return;
}

void Depositardinheiro()
{
 Console.WriteLine("== Função em desenvolvimento ==");
}

void SacarDinheiro()
{
  Console.WriteLine("== Função em desenvolvimento ==");
}

void TransferirDinheiro()
{
  Console.WriteLine("== Função em desenvolvimento ==");
}

void ListarClientes()
{
    Console.WriteLine("== Listagem de Clientes ==");
    for (int t = 0; t < totalclientes; t++)
    {
        Console.WriteLine($"{t} nome - {nomes[t]} dinheiro - {dinheiro[t]}");
    }
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
    return;
}