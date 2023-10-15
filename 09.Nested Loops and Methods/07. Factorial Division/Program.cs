static long CalculateFactorial(long number)
{
    long result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

long number1 = long.Parse(Console.ReadLine());
long number2 = long.Parse(Console.ReadLine());

long n1 = CalculateFactorial(number1);
long n2 = CalculateFactorial(number2);
long res = n1 / n2;
Console.WriteLine(res);