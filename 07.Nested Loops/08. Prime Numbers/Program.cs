int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int count = 0;

for (int s = start; s <= end; s++)
{
    for (int x = 1; x <= s; x++)
    {
        if (s % x == 0)
        {
            count++;
        }
    }
    if (count == 2)
    {
        Console.Write($"{s} ");
    }
    count = 0;
}