List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (true)
{
    int sumOfAll = 0;
    string input = Console.ReadLine();
    if (input == "end")
    {
        Console.WriteLine(string.Join(" ", numbers));
        break;
    }

    string[] comms = input.Split(" ");
    
    if (comms[0] == "Contains")
    {
        if (numbers.Contains(int.Parse(comms[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (comms[0] == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (comms[0] == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (comms[0] == "GetSum")
    {
        foreach (int number in numbers)
        {
            sumOfAll += number;
        }
        Console.WriteLine(sumOfAll);
    }
    else if (comms[0] == "Filter")
    {
        int con = int.Parse(comms[2]);
        if ((comms[1] == "<"))
        {
            numbers.RemoveAll(x => x >= con);
        }
        else if ((comms[1] == ">"))
        {
            numbers.RemoveAll(x => x <= con);
        }
        else if (((comms[1] == ">=")))
        {
            numbers.RemoveAll(x => x < con);
        }
        else if (comms[1] == "<=")
        {
            numbers.RemoveAll(x => x > con);
        }
    }
}

