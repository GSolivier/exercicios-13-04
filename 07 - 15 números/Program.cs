float[] numeros = new float[15];


for (var i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Array.Reverse(numeros);

Console.WriteLine();
Console.WriteLine($"A ordem inversa dos números é:");

for (var i = 0; i < numeros.Length; i++)
{
Console.WriteLine($"{numeros[i]}");
}
