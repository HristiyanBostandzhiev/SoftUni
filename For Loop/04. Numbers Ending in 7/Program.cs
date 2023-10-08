int number = int.Parse(Console.ReadLine());

for (int x = 0; x <= number; x++)
{
    if (x % 10 == 7)
    {
        Console.WriteLine(x);
    }
}