// Ler o nome do produto, a quantidade adquirida, e o preço unitário.
// Calcular o preço total (total = preço unitário * quantidade adquirada) e o desconto (totalDesconto = total - desconto)

// Se a quantidade for até 5 unidades - desconto de 2%
// Se for de 6 a 10 - desconto de 3%
// acima de 10 o desconto será de 5%

using System.Globalization;
using System.Text.RegularExpressions;


string nomeProduto;
float precoProduto;
float precoDesconto;
var quantidadeProduto = 0;
bool loopBreak = true;

do
{
    
Console.WriteLine($"Digite o nome do produto que deseja comprar: ");
nomeProduto = Console.ReadLine();    

bool ok = Regex.IsMatch(nomeProduto, "^[a-zA-Z_ ]+$");

if(!ok || string.IsNullOrEmpty(nomeProduto) || string.IsNullOrWhiteSpace(nomeProduto))
{
    Console.WriteLine($"o valor digitado não é válido.");
    loopBreak = true;
}
else{
    loopBreak = false;
}
} while (loopBreak);


do
{
Console.WriteLine($"Digite quantas unidades do produtos você quer adquirir: ");
quantidadeProduto = int.Parse(Console.ReadLine());

bool ok = Regex.IsMatch(quantidadeProduto, "^[0-9]+$");

if(!ok || string.IsNullOrEmpty(quantidadeProduto) || string.IsNullOrWhiteSpace(quantidadeProduto))
{
    Console.WriteLine($"o valor digitado não é válido.");
    loopBreak = true;
}
else{
    loopBreak = false;
}
} while (loopBreak);

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
