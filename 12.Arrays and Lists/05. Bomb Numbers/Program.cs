List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> special = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int bomb = special[0];
int power = special[1];

for (int index = 0; index < numbers.Count; index++)
{
    if (numbers[index] == bomb)
    {
        if (power >= (numbers.Count - 1) - index)
        {
            numbers.RemoveRange(Math.Max(0, index - power), numbers.Count - Math.Max(0, index - power));
            index = -1;
        }
        else if (index <= power)
        {
            numbers.RemoveRange(0, index + power + 1);
            index = -1;
        }
        else
        {
            numbers.RemoveRange(index - power, power + power + 1);
            index = -1;
        }
    }
}

Console.WriteLine(numbers.Sum());