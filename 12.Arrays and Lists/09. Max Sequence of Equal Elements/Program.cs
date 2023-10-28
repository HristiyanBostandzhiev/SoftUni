string input_str = Console.ReadLine();
string[] words = input_str.Split(' ');
int count = 0;
int maxCount = 0;
string maxWord = "";

for (int i = 0; i < words.Length; i++)
{
    if (i > 0 && words[i] == words[i - 1])
    {
        count++;
    }
    else
    {
        count = 1;
    }

    if (count > maxCount)
    {
        maxCount = count;
        maxWord = words[i];
    }
}

Console.WriteLine(maxWord);