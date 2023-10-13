static double powerOf (double baseNumber, double power)
{
    double result = Math.Pow (baseNumber, power);
    return result;
}

double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());

double output = powerOf(number1, number2);
Console.WriteLine(output);