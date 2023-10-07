string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());
double price = 0;
double finalPrice = 0;

if (type == "Premiere")
{
    price = 12.00;
    finalPrice = (rows * seatsPerRow) * price;
    Console.WriteLine($"{finalPrice:f2}");
}
else if (type == "Normal")
{
    price = 7.50;
    finalPrice = (rows * seatsPerRow) * price;
    Console.WriteLine($"{finalPrice:f2}");
}
else if (type == "Discount")
{
    price = 5.00;
    finalPrice = (rows * seatsPerRow) * price;
    Console.WriteLine($"{finalPrice:f2}");
}