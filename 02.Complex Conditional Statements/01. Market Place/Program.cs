string prodcut = Console.ReadLine();
string day = Console.ReadLine();

if (prodcut == "Banana")
{
    if (day == "Weekday")
        Console.WriteLine("2.50");
    else
        Console.WriteLine("2.70");
}
else if (prodcut == "Apple")
{
    if (day == "Weekday")
        Console.WriteLine("1.30");
    else
        Console.WriteLine("1.60");
}
else if (prodcut == "Kiwi")
{
    if (day == "Weekday")
        Console.WriteLine("2.20");
    else
        Console.WriteLine("3.00");
}