int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumOfNumbers = 0;

foreach (var num in numbers)
{
    sumOfNumbers += num;
}

Console.WriteLine(sumOfNumbers);