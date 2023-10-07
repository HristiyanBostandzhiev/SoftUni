string type = Console.ReadLine();

if (type == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:f2}");
}
else if (type == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double area = sideA * sideB;
    Console.WriteLine($"{area:f2}");
}
else if (type == "circle")
{
    double radious = double.Parse(Console.ReadLine());
    double area = Math.Pow(radious, 2) * Math.PI;
    Console.WriteLine($"{area:f2}");
}
else
    Console.WriteLine("Invalid figure.");