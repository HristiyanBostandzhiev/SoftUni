int maxNum = int.Parse(Console.ReadLine());
int startNum = 1;

while (startNum <= maxNum)
{
    Console.WriteLine(startNum);
    startNum = (startNum * 2) + 1;
}