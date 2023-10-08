int amount = int.Parse(Console.ReadLine());
int currentNum = int.MinValue;

for (int x = 1; x <= amount; x++)
{
    int numbers = int.Parse(Console.ReadLine());
    if (numbers > currentNum)
    {
        currentNum = numbers;
    }
}
Console.WriteLine(currentNum);