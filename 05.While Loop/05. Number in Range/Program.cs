while (true)
{
start:
    int number = int.Parse(Console.ReadLine());

    if (number >= 1 && number <= 100)
    {
        Console.WriteLine(number);
        break;
    }
    else
    {
        goto start;
    }
}