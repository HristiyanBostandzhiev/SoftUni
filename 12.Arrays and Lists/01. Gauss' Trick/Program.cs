List<int> gaussInput = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> gaussOutput = new List<int>();

for (int i = 0; i < gaussInput.Count / 2; i++)
{
	int sum = gaussInput[0 + i] + gaussInput[gaussInput.Count - 1 - i];
	gaussOutput.Add(sum);
}

if (gaussInput.Count % 2 != 0)
{
	int num = gaussInput[gaussInput.Count / 2];
    gaussOutput.Add(num);
}

Console.WriteLine(string.Join(" ", gaussOutput));