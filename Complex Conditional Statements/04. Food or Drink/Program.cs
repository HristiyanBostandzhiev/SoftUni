string product = Console.ReadLine();

switch (product)
{
    case "curry":
    case "noodles":
    case "sushi":
    case "spaghetti":
    case "bread": Console.WriteLine("food"); break;
    case "tea":
    case "water":
    case "juice":
    case "coffee": Console.WriteLine("drink"); break;
    default: Console.WriteLine("unknown"); break;
}