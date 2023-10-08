int number = int.Parse(Console.ReadLine());
int lastDigit = 0;
int initialNumber = number;

while (true)
{
    lastDigit = number % 10;
    number = number / 10;
    if (lastDigit == 0)
    {
        Console.WriteLine($"{initialNumber} is special");
        break;
    }
    if (initialNumber % lastDigit != 0)
    {
        Console.WriteLine($"{initialNumber} is not special");
        break;
    }
}