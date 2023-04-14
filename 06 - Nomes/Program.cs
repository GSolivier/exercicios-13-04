// Ler o nome de 10 pessoas, e armazenar eles em um vetor.
// depois, permitir a leitura de mais um nome, como se fosse uma pesquisa
// verificar se o nome escrito se encontra no array.
// retornar para o usuário

string[] nomes = new string[11];


for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine().ToLower();
}

Console.WriteLine($"Digite o nome que deseja procurar: ");
string nomePesquisa = Console.ReadLine().ToLower();



    if (nomes.Contains(nomePesquisa))
    {
        Console.WriteLine($"ACHEI! O nome {nomePesquisa.ToUpper()} está na minha lista"); 
    }
    else{
        Console.WriteLine($"Não achei.");
        
    }
