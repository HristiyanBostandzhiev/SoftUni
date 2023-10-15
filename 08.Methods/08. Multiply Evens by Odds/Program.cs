static int GetSumOfDigits (int integerNumber)
{
    int sumOfEven = 0;
    int sumOfOdd = 0;

    while (true)
    {
        int currentLastDigit = integerNumber % 10;
        if (currentLastDigit % 2 == 0)
        {
            sumOfEven += currentLastDigit;
        }
        else if (currentLastDigit % 2 != 0)
        {
            sumOfOdd += currentLastDigit;
        }
        integerNumber = integerNumber / 10;
        if (integerNumber == 0)
        {
            break;
        }
    }
    int finalResult = sumOfOdd * sumOfEven;
    return finalResult;
}

var input = int.Parse(Console.ReadLine());

int final = GetSumOfDigits(input);

Console.WriteLine(final);