int number = int.Parse(Console.ReadLine());


for (int x = 0; x <= number; x++)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(Math.Pow(2, x));
    }
}