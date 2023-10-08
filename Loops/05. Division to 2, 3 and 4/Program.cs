double count = double.Parse(Console.ReadLine());
double two = 0;
double three = 0;
double four = 0;

for (int x = 1; x <= count; x++)
{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        two++;
    }
    if (number % 3 == 0)
    {
        three++;
    }
    if (number % 4 == 0)
    {
        four++;
    }
}
double res2 = (two / count) * 100;
double res3 = (three / count) * 100;
double res4 = (four / count) * 100;
Console.WriteLine($"{res2:f2}%");
Console.WriteLine($"{res3:f2}%");
Console.WriteLine($"{res4:f2}%");