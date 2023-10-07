string drinkName = Console.ReadLine();
string extra = Console.ReadLine();

if (drinkName == "coffee")
{
    switch (extra)
    {
        case "sugar": Console.WriteLine("Final price: $1.40"); break;
        case "no": Console.WriteLine("Final price: $1.00"); break;
        default: Console.WriteLine("Unknown extra"); break;
    }
}
else if (drinkName == "tea")
{
    switch (extra)
    {
        case "sugar": Console.WriteLine("Final price: $1.00"); break;
        case "no": Console.WriteLine("Final price: $0.60"); break;
        default: Console.WriteLine("Unknown extra"); break;
    }
}
else
{
    Console.WriteLine("Unknown drink");
}