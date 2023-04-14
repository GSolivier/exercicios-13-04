// Mostrar a tabuada dos números de 1 a 10 para o usuário

int resultado;

Console.WriteLine($"Pressione a tecla 'Enter' para iniciar o programa...");

while (Console.ReadKey(true).Key != ConsoleKey.Enter) {
        }

for (var i = 1; i <= 10; i++)
{

    Console.WriteLine($"Tabuada do {i}:");

    for (int j = 1; j <= 10; j++)
    {

        resultado = i * j;
        Console.WriteLine($"{i} X {j} = {resultado}");
        
    }
    
    Console.WriteLine($"");
    
    
}

