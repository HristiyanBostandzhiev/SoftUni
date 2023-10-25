List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> output = new List<int>();


while (input.Count > 1)
{
    for (int control = 0; control < input.Count - 1; control++)
    {
        int res = input[0 + control] + input[1 + control];
        output.Add(res);
    }
    input = output;
    output = new List<int>();
}


Console.WriteLine(string.Join(" ", input));