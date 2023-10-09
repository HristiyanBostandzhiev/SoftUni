double totalMoney = 0;

while (true)
{
    totalMoney = 0;
    string destination = Console.ReadLine();
    if (destination == "End")
    {
        break;
    }
    double budgetNeeded = double.Parse(Console.ReadLine());

    while (true)
    {
        if (totalMoney == budgetNeeded || totalMoney > budgetNeeded)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }
        double amount = double.Parse(Console.ReadLine()); 
        totalMoney += amount;
        Console.WriteLine($"Collected: {totalMoney:F2}");
    }
}