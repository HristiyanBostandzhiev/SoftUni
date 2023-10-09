int floorsTotal = int.Parse(Console.ReadLine());
int estatesTotal = int.Parse(Console.ReadLine());

for (int floor = floorsTotal; floor >= 1; floor--)
{
    for (int estate = 0; estate < estatesTotal; estate++)
    {
        if (floor == floorsTotal)
        {
            Console.Write($"L{floor}{estate} ");
        }
        else if (floor % 2 == 0)
        {
            Console.Write($"O{floor}{estate} ");
        }
        else
        {
            Console.Write($"A{floor}{estate} ");
        }
    }
    Console.WriteLine();
}