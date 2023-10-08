int numb = int.Parse(Console.ReadLine());
int sumOfAll = 0;

for (int x = 1; x <= numb; x++)
{
    if (x == 1)
    {
        Console.Write(x);
    }
    else
    {
        Console.Write("+" + x);
    }

    sumOfAll += x;
}

Console.WriteLine("=" + sumOfAll);