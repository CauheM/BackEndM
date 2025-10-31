using ClasseEObjetos;

//AgenciaBancaria Cauhe = new AgenciaBancaria();
//Cauhe.Depositar = 0;
//Cauhe.Sacar = 0;

//int opcao = -1;

//do
//{
//    Console.Clear();
//    Console.WriteLine("==== Agencia do VSFN ====");
//    Console.WriteLine("==== 0- Sair ====");
//    Console.WriteLine("==== 1- Depositar ====");
//    Console.WriteLine("==== 2- Sacar ====");
//    opcao = int.Parse(Console.ReadLine());
//    switch (opcao)
//    {
//        case 0:
//            Console.WriteLine("Encerrando...");
//            break;
//
//        case 1:
//            Cauhe.DepositarDinheiro();
//            break;
//
//        case 2:
//            Cauhe.SacarDinheiro();
//            break;
//    }
//} while (opcao != 0);

ProdutocomDesconto Camiseta = new ProdutocomDesconto();
Camiseta.nome = "Camiseta";
Camiseta.preco = 100;

Camiseta.AplicarDesconto();
