int number = int.Parse(Console.ReadLine());
int sum = 0;

while (true)
{
    if (number / 10 == 0)
    {
        sum = sum + number;
        Console.WriteLine(sum);
        break;
    }
    sum = sum + number % 10;
    number = number / 10;
}