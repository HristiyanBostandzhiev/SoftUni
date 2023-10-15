//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 =  int.Parse(Console.ReadLine());

//int result = num1 * num2 * num3;
//if (result > 0)
//{
//    Console.WriteLine("positive");
//}
//else if (result < 0)
//{
//    Console.WriteLine("negative");
//}
//else
//{
//    Console.WriteLine("zero");
//}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int result = 0;

if (num1 == 0 || num2 == 0 || num3 == 0)
{
    result = 0;
}
else if ((num1 < 0 && num2 < 0 && num3 < 0) || (num1 < 0 && num2 > 0 && num3 > 0) 
         || (num1 > 0 && num2 < 0 && num3 > 0) || (num1 > 0 && num2 > 0 && num3 < 0))
{
    result = -1;
}
else
{
    result = 1;
}

PrintSign(result);

static void PrintSign(int number)
{
    if (number > 0)
    {
        Console.WriteLine("positive");
    }
    else if (number < 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("zero");
    }
}
