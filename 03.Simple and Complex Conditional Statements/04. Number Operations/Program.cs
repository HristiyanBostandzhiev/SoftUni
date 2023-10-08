double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());

double result = 0;

switch (op)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result:f2}");
        break;
    case '-':
        result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result:f2}");
        break;
    case '*':
        result = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result:f2}");
        break;
    case '/':
        result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:f2}");
        break;
}