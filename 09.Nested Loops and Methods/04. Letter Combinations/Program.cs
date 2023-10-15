char a = char.Parse(Console.ReadLine());
char b = char.Parse(Console.ReadLine());
char exclude = char.Parse(Console.ReadLine());

int combinations = 0;

for (char first = a; first <= b; first++)
{
    for (char second = a; second <= b; second++)
    {
        for  (char third = a; third <= b; third++)
        {
            if (first != exclude && second != exclude && third != exclude)
            {
                Console.Write($"{first}{second}{third} ");
                combinations++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(combinations);