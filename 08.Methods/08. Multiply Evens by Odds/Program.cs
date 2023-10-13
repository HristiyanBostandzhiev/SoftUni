static int GetSumOfEvenDigits (int integerNumber)
{
    if (integerNumber < 0)
        integerNumber = Math.Abs(integerNumber);

    int sumOfEven = 0;

    while (true)
    {
        int currentLastDigit = integerNumber % 10;
        if (currentLastDigit % 2 == 0)
        {
            sumOfEven = sumOfEven + currentLastDigit;
        }
        integerNumber = integerNumber / 10;
        if (integerNumber == 0)
        {
            break;
        }
    }
    return sumOfEven;
}
static int GetSumOfOddDigits (int integerNumber)
{
    if (integerNumber < 0)
        integerNumber = Math.Abs(integerNumber);

    int sumOfOdd = 0;

    while (true)
    {
        int currentLastDigit = integerNumber % 10;
        if (currentLastDigit % 2 != 0)
        {
            sumOfOdd = sumOfOdd + currentLastDigit;
        }
        integerNumber = integerNumber / 10;
        if (integerNumber == 0)
        {
            break;
        }
    }
    return sumOfOdd;
}
static int GetMultipleOfEvenAndOdds (int num1, int num2)
{
    return num1 * num2;
}

var input = int.Parse(Console.ReadLine());

int even = GetSumOfEvenDigits(input);
int odd = GetSumOfOddDigits(input);
int final = GetMultipleOfEvenAndOdds(even, odd);

Console.WriteLine(final);