int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i += 2)
{
    for (int j = 1; j <= number; j += 2)
    {
        Console.Write($"{i}{j}{i * j} ");
    }
}