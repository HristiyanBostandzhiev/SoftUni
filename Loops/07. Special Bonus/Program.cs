int specialNumber = int.Parse(Console.ReadLine());
int now = 0;

while (true)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber == specialNumber)
    {
        Console.WriteLine(now * 1.20);
        break;
    }
    now = currentNumber;
}