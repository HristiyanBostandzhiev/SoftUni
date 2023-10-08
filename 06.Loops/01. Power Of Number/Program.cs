int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int res = number;

for (int x = 1; x < power; x++)
{
    res = res * number;
}
Console.WriteLine(res);