int input = int.Parse(Console.ReadLine());
int count = 0;

for (int a = 0; a <= input; a++)
{
    for (int j = 0; j <= input; j++) ;
    {
        for (int c = 0; c <= input; c++)
        {
            if (a + j + c == input)
            {
                count++;
            }
        }
    }
}
Console.WriteLine(count);