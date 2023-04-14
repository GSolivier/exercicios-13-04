// Ler o número de litros vendidos
// A - Alcool e G - Gasolina

// Alcool:
// Até 20 litros - desconto de 3% por litro
// acima de 20 litros - desconto de 5% por litro

// Gasolina:
// Até 20 litros - desconto de 4% por litro
// Acima de 20 litros - desconto de 6% por litro

// Preço por litro de Alcool - R$ 4,90
// Preço por litro de Gasolina - R$ 5,30

using System.Globalization;
CultureInfo reais = new CultureInfo("pt-BR");

static double DescontoPorLitroAlcool(double alcool)
{
    if (alcool <= 20)
    {
        return (4.9 * alcool) * 0.97;
    }

    else{
        return (4.9 * alcool) * 0.95;
    }
}

static double DescontoPorLitroGasolina(double gasolina)
{
    if (gasolina <= 20)
    {
        return (5.3 * gasolina) * 0.96;
    }

    else{
        return (5.3 * gasolina) * 0.94;
    }
}

bool loopBreak = true;


do
{
Console.WriteLine(@$"
        Bem vindo ao nosso posto de abastecimento.

    Informe qual tipo de combustível deseja utilizar:

                    'G' - Gasolina
                    'A' - Alcool
");
string tipoComb = Console.ReadLine().ToLower();

    switch (tipoComb)
    {
        case "g":
        Console.WriteLine($"Digite a quantidade de litros de gasolina que deseja abastecer:");
        int litrosG = int.Parse(Console.ReadLine());
        
        double descontoG = DescontoPorLitroGasolina(litrosG);
        Console.WriteLine($"O valor total com desconto é de {Math.Round(descontoG,2).ToString("C", reais)}");
        
        loopBreak = false;
            break;

        case "a":
        Console.WriteLine($"Digite a quantidade de litros de alcool que deseja abastecer:");
        int litrosA = int.Parse(Console.ReadLine());
        
        double descontoA = DescontoPorLitroAlcool(litrosA);
        Console.WriteLine($"O valor total com desconto é de {Math.Round(descontoA,2).ToString("C", reais)}");
        loopBreak = false;
            break;

        default:
        Console.WriteLine($"Digite uma letra válida, por favor");
        loopBreak = true;
            break;
    }
    
} while (loopBreak);
