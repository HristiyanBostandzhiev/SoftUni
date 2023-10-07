int points = int.Parse(Console.ReadLine());
int bonusPoints = 0;

if (points >= 0 && points <= 3)
{
    bonusPoints = 5;
    Console.WriteLine(points + bonusPoints);
}
else if (points >= 4 && points <= 6)
{
    bonusPoints = 15;
    Console.WriteLine(points + bonusPoints);
}
else if (points >= 7 && points <= 9)
{
    bonusPoints = 20;
    Console.WriteLine(points + bonusPoints);
}