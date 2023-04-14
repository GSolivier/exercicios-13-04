// Ler o nome do produto, a quantidade adquirida, e o preço unitário.
// Calcular o preço total (total = preço unitário * quantidade adquirada) e o desconto (totalDesconto = total - desconto)

// Se a quantidade for até 5 unidades - desconto de 2%
// Se for de 6 a 10 - desconto de 3%
// acima de 10 o desconto será de 5%

using System.Globalization;

string nomeProduto;
int quantidadeProduto;
float precoProduto;
float precoDesconto;

Console.WriteLine($"Digite o nome do produto que deseja comprar: ");
nomeProduto = Console.ReadLine();

Console.WriteLine($"Digite quantas unidades do produtos você quer adquirir: ");
quantidadeProduto = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preço do produto (por unidade): ");
precoProduto = float.Parse(Console.ReadLine());

if (quantidadeProduto <= 5)
{
    precoDesconto = (quantidadeProduto * precoProduto) * 0.98f;
}

else if (quantidadeProduto < 10)
{
    precoDesconto = (quantidadeProduto * precoProduto) * 0.97f;
}

else
{
    precoDesconto = (quantidadeProduto * precoProduto) * 0.95f;
}

Console.WriteLine($"O preço do(a) {nomeProduto} com o desconto aplicado é de {Math.Round(precoDesconto,2).ToString("C", new CultureInfo("pt-BR"))}");
