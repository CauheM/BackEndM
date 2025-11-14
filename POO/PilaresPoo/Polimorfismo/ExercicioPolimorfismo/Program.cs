using ExercicioPolimorfismo;

PagamentoPix comprapix = new PagamentoPix();
comprapix.ValorCompra = 1500;
float valorpagar = comprapix.CalcularTotal();
Console.WriteLine($"Celular");
Console.WriteLine($"Preço: {comprapix.ValorCompra}");
Console.WriteLine($"Pagamento com desconto: {valorpagar}");

PagamentoCartao compracartao = new PagamentoCartao();
compracartao.ValorCompra = 60;

Console.WriteLine($"Caneco");
Console.WriteLine($"Preço: {compracartao.ValorCompra}");
Console.WriteLine($"Tipo de pagamento: Cartão");
Console.WriteLine($"Pagamento com desconto: {compracartao.CalcularTotal()}");

