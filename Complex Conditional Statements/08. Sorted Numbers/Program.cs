double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
double number3 = double.Parse(Console.ReadLine());

if (number1 < number2 && number2 < number3)
{
    Console.WriteLine("Ascending");
}
else if (number1 > number2 && number2 > number3)
{
    Console.WriteLine("Descending");
}
else if (number1 > number2 || number1 < number3 || number2 > number3)
{
    Console.WriteLine("Not sorted");
}