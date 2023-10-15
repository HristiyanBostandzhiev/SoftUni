int digit1 = int.Parse(Console.ReadLine());
int digit2 = int.Parse(Console.ReadLine());
int digit3 = int.Parse(Console.ReadLine());

for (int d1 = 1; d1 <= digit1; d1++)
{
    for (int d2 = 1;d2 <= digit2; d2++)
    {
        for (int d3 = 1; d3 <= digit3; d3++)
        {
            if (d1 % 2 == 0 && d3 % 2 == 0 && d2 != 4 && d2 != 6 && d2 != 1)
            Console.WriteLine($"{d1}{d2}{d3}");
        }
    }
}