List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }

    string[] commands = input.Split(" "); 

    if (commands[0] == "Add")
    {
        numbers.Add(int.Parse(commands[1]));
    }
    else if (commands[0] == "Remove")
    {
        numbers.RemoveAll(n => n == int.Parse(commands[1]));
    }
    else if (commands[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(commands[1]));
    }
    else if (commands[0] == "Insert")
    {
        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
    }
}

Console.WriteLine(string.Join(" ", numbers));