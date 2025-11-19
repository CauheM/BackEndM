using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using Exercicio2;

List<Fatura> listaFaturas = new List<Fatura>();
List<Relatorio> listaRelatorio = new List<Relatorio>();
List<Contrato> listaContrato = new List<Contrato>();
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao = -1;

do{

Console.Clear();
Console.WriteLine("Olá, bem vindo ao VNFN, o q vc deseja fazer");
Console.WriteLine("1 - Cadastrar Fatura");
Console.WriteLine("2- Cadastrar relatório");
Console.WriteLine("3- Cadastras Contrato");
Console.WriteLine("4- Listar Faturas");
Console.WriteLine("5- Listar Relatórios");
Console.WriteLine("6- Listar Contratos");
Console.WriteLine("0- Sair");
Console.Write("Escolha uma opção: ");
opcao = int.Parse(Console.ReadLine());

switch(opcao)
    {
        case 0:
        Console.Clear();
        Console.WriteLine("Encerrando..."); 
        return;
        break;
        case 1:
        Console.Clear();
        CadastrarFaturas();
        break;
        case 2:
        Console.Clear();
        Console.WriteLine("Cadastrar Relatório de desenvolvimento");
        break;
        case 3:
        Console.Clear();
        Console.WriteLine("Cadastrar Contrato de desenvolvimento");
        break;
        case 4:
        Console.Clear();
        ListarFaturas();
        break;
        case 5:
        Console.Clear();
        Console.WriteLine("Listar Relatórios em desenvolvimento");
        break;
        case 6:
        Console.Clear();
        Console.WriteLine("Listar Contratos em desenvolvimento");
        break;
    }

    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}
while(opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine("Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine("Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine("Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine("Dias de atraso da fatura");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine("Cliente cadastrado com sucesso");

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);
}

void CadastrarRelatorios()
{
    
}

void CadastrarContratos()
{
    
}

void ListarFaturas()
{
  Console.WriteLine("Listando Faturas:");
  foreach(var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }  
}

void ListarRelatorios()
{
  Console.WriteLine("Listando Relatorios:");
  foreach(var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }  
}

void ListarContratos()
{
  Console.WriteLine("Listando Contratos:");
  foreach(var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }  
}











// Fatura F = new Fatura();
// listaFaturas.Add(F);

// Fatura F2 = new Fatura();
// listaFaturas.Add(F2);

// Relatorio R = new Relatorio();
// listaRelatorio.Add(R);

// Contrato C = new Contrato();
// listaContrato.Add(C);

// foreach(var fat in documentos)
// {
//     Console.WriteLine("Fatura");
//     if (fat is Fatura)
//     {
//       fat.Imprimir();    
//     }
    
// }

// foreach(var item in documentos)
// {
//     Console.WriteLine("Fatura");
//     if (item is Relatorio)
//     {
//       item.Imprimir();    
//     }
    
// }

// foreach(var item in documentos)
// {
//     Console.WriteLine("Fatura");
//     if (item is Contrato)
//     {
//       item.Imprimir();    
//     }
    
// }