/*Um cliente quer solicitar um empréstimo.
 Receba o valor solicitado
 quantidade de parcelas desejada
 renda mensal comprovada. 
 Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros).
*/
double valorSolicitado,rendaMensal, valorParcela;
int qtdParcela;
Console.WriteLine("EMPRETIMO");
Console.WriteLine("Qual valor gostaria de solicitar.:");
    valorSolicitado = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parcelas.:");
    qtdParcela = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite sua renda.:");
rendaMensal = Convert.ToDouble(Console.ReadLine());
valorParcela = valorSolicitado/qtdParcela;
double preco = rendaMensal*0.31;
if (valorParcela < preco )
{
Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Emprestimo autorizado");
    Console.WriteLine($"Valor a ser pago:{valorParcela:C2}");
Console.ResetColor();
}else
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Emprestimo NEGADO");
    Console.WriteLine("Valor do emprestimo maior que 30% da renda");
Console.ResetColor();
}

