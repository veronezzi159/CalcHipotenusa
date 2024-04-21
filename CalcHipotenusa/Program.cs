double hipotesuna, cateto1 = 0, cateto2 = 0, meio = 0;
meio = 0.5;
do
{
    Console.WriteLine("digite o primeiro cateto");
    cateto1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo cateto");
    cateto2 = double.Parse(Console.ReadLine());
    if (cateto1 == 0 || cateto2 == 0)
    {
        Console.WriteLine("Cateto inserido com valor zeradou ou negativo, repita o procedimento");
    }
} while (cateto1 <= 0 || cateto2 <= 0);

hipotesuna = Math.Pow(((cateto1*cateto1) + (cateto2* cateto2)), meio );

Console.WriteLine($"A hipotenusa é apoximadamente {Math.Round(hipotesuna, 4)}");