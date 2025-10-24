Console.WriteLine("olá, digite a senha");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("Conta acessada");
}
else{
    Console.WriteLine("senha incorreta");
}