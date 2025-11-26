using System.Security.Claims;
using encapsulamento;

ContaBancaria conta = new ContaBancaria();

Console.Clear();

conta.Depositar(50);
conta.Sacar(25);

Console.WriteLine($"Saldo atual: R${conta.GetSaldo()}");