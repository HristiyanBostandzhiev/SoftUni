List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        Console.WriteLine(string.Join(" ", ints));
        break;
    }
    string[] command = input.Split(" ");
    
    if (command[0] == "Delete")
    {
        while (ints.Contains(int.Parse(command[1])))
        {
            ints.Remove(int.Parse(command[1]));
        }
    }
    else if (command[0] == "Insert")
    {
        ints.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
}