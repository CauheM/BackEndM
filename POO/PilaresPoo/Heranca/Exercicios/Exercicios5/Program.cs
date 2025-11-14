 using Exercicios5;
 
 ContaPoupanca Conta = new ContaPoupanca();
 Conta.Numero = 123;

    Console.Clear();

    Console.WriteLine($"Saldo inicial: {Conta.Saldo:F2}");

    Conta.Depositar(2500);

    Console.WriteLine($"Saldo após depósito: {Conta.Saldo:F2}");

    Conta.Sacar(250);

    Console.WriteLine($"Saldo após de sacar: {Conta.Saldo:F2}");    

    Conta.CalcularRendimento();

    Console.WriteLine($"Saldo após rendimento de 2%: {Conta.Saldo:F2}");