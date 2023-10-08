int numbersToSum = int.Parse(Console.ReadLine());
double sumOfAll = 0;

for (int x = 1; x <= numbersToSum; x++)
{
    double numbers = double.Parse(Console.ReadLine());
    sumOfAll += numbers;
}

Console.WriteLine(sumOfAll);