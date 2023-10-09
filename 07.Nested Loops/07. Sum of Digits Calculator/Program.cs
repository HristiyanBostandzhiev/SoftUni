int sumOfNumber = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    int number = int.Parse(input);
    while (true)
    {
        sumOfNumber += number % 10;
        number = number / 10;
        if (number == 0)
        {
            Console.WriteLine($"Sum of digits = {sumOfNumber}");
            sumOfNumber = 0;
            break;
        }
    }
}