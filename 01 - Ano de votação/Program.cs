// Ler o ano atual e o ano de nascimento do usuário
// processar se a pessoa pode votar
// exibir essa mensagem na tela.

int anoAtual = DateTime.Now.Year;
int anoUser = 0;

Console.WriteLine($"Digite o seu ano de nascimento: ");
anoUser = int.Parse(Console.ReadLine());

int idade = anoAtual - anoUser;

if(idade >= 18)
{
    Console.WriteLine($"Você pode votar esse ano.");
    
}

else{
    Console.WriteLine($"Você não pode votar esse ano.");
    
}
