string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

double totalPrice = 0;

switch (season)
{
    case "Spring":
        if (accommodation == "Hotel")
        {
            totalPrice = (countOfDays * 30) * 0.8;
            Console.WriteLine($"{totalPrice:f2}");
        }
        else if (accommodation == "Camping")
        {
            totalPrice = (countOfDays * 10) * 0.8;
            Console.WriteLine($"{totalPrice:f2}");
        }
        break;
    case "Summer":
        if (accommodation == "Hotel")
        {
            totalPrice = countOfDays * 50;
            Console.WriteLine($"{totalPrice:f2}");
        }
        else if (accommodation == "Camping")
        {
            totalPrice = countOfDays * 30;
            Console.WriteLine($"{totalPrice:f2}");
        }
        break;
    case "Autumn":
        if (accommodation == "Hotel")
        {
            totalPrice = (countOfDays * 20) * 0.7;
            Console.WriteLine($"{totalPrice:f2}");
        }
        else if (accommodation == "Camping")
        {
            totalPrice = (countOfDays * 15) * 0.7;
            Console.WriteLine($"{totalPrice:f2}");
        }
        break;
    case "Winter":
        if (accommodation == "Hotel")
        {
            totalPrice = (countOfDays * 40) * 0.9;
            Console.WriteLine($"{totalPrice:f2}");
        }
        else if (accommodation == "Camping")
        {
            totalPrice = (countOfDays * 10) * 0.9;
            Console.WriteLine($"{totalPrice:f2}");
        }
        break;
}