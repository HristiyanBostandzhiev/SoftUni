var hour = int.Parse(Console.ReadLine());
var dayOfWeek = Console.ReadLine();

if (dayOfWeek != "Sunday")
{
    if (hour >= 10 && hour <= 18)
        Console.WriteLine("open");
    else
        Console.WriteLine("closed");
}
else
    Console.WriteLine("closed");