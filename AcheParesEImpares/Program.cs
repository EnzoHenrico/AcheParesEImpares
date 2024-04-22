int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Item {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nValores pares: ");
for (int i = 0; i < 10; i++)
{
    if ((numbers[i] % 2) == 0)
    {
        Console.WriteLine("- " + numbers[i]);
    }
}

Console.WriteLine("\nValores impares: ");
for (int i = 0; i < 10; i++)
{
    if ((numbers[i] % 2) != 0)
    {
        Console.WriteLine("- " + numbers[i]);
    }
}

Console.WriteLine("Número na primeira posição: " + numbers[0]);
Console.WriteLine("Número na última posição: " + numbers[9]);