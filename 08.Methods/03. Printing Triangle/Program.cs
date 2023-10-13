static void PrintLine(int start, int end)
{
    for (int x = start; x <= end; x++)
    {
        Console.Write(x + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle (int y)
{
    for (int line = 1; line <= y; line++)
    {
        PrintLine(1, line);
    }
    for (int line = y - 1; line >= 1; line--)
    {
        PrintLine(1, line);
    }
}

int input = int.Parse(Console.ReadLine());

PrintTriangle(input);