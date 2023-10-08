int number = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    else if (command == "Inc")
    {
        number += 1;
    }
    else if (command == "Dec")
    {
        number -= 1;
    }
}
Console.WriteLine(number);