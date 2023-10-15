int n = int.Parse(Console.ReadLine());

for (int firstNum = 1; firstNum <= 9; firstNum++)
{
    for (int secondNum = 0; secondNum <= 9; secondNum++)
    {
        for (int thirdNum = 0; thirdNum <= 9; thirdNum++)
        {
            for(int fourthNum = 0; fourthNum <= 9; fourthNum++)
            {
                if (firstNum + secondNum == thirdNum + fourthNum && thirdNum + fourthNum == n)
                {
                    Console.Write($"{firstNum}{secondNum}{thirdNum}{fourthNum} ");
                }
            }
        }
    }
}