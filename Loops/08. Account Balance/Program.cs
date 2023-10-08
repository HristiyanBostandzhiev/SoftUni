double balance = 0;

while (true)
{
    string money = Console.ReadLine();
    if (money == "End")
    {
        Console.WriteLine($"Balance: {balance:f2}");
        break;
    }
    double convert = double.Parse(money);
    if (convert < 0)
    {
        convert = Math.Abs(convert);
        balance = balance - convert;
        Console.WriteLine($"Decrease: {convert:f2}");
    }
    else if (convert > 0)
    {
        balance = balance + convert;
        Console.WriteLine($"Increase: {convert:f2}");
    }
}