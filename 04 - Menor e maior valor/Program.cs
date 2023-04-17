// Ler 10 números do usuário
// retornar o menor e o maior valor

float[] numeros = new float[10];
float menor = 16777216;
float maior = 0;

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número:");
    numeros[i] = float.Parse(Console.ReadLine());

maior = Math.Max(numeros[i], maior);
menor = Math.Min(numeros[i], menor);
}
Console.WriteLine();

Console.WriteLine($"O maior número é o {maior}");
Console.WriteLine($"O menor número é o {menor}");
