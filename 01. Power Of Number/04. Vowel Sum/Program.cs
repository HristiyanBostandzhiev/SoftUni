int countOfChars = int.Parse(Console.ReadLine());
int totalSum = 0;

for (int x = 1; x <= countOfChars; x++)
{
    string chars = Console.ReadLine();
    switch (chars)
    {
        case "a": totalSum = totalSum + 1; break;
        case "e": totalSum = totalSum + 2; break;
        case "i": totalSum = totalSum + 3; break;
        case "o": totalSum = totalSum + 4; break;
        case "u": totalSum = totalSum + 5; break;
    }
}
Console.WriteLine(totalSum);