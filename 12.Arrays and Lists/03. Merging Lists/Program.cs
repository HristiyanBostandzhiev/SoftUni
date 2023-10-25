List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> result = new List<int>();

int biggestList = Math.Max(input1.Count, input2.Count);

for (int i = 0; i < biggestList; i++)
{
    if (i < input1.Count)
    {
        result.Add(input1[i]);
    }
    if (i < input2.Count)
    {
        result.Add(input2[i]);
    }
}

Console.WriteLine(string.Join(" ", result));
