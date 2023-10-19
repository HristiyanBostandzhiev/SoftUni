int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumOfOdd = 0;
int sumOfEvens = 0;

foreach (var num in numbers)
{
    if (num % 2 == 0)
    {
        sumOfEvens += num;
    }
    else
    {
        sumOfOdd += num;
    }
}

Console.WriteLine(sumOfEvens - sumOfOdd);