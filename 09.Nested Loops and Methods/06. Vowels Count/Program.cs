//int vowelCount = 0;

//char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

//foreach (char x in input)
//{
//    if (Array.IndexOf(vowels, x) >= 0)
//    {
//        vowelCount++;
//    }
//}
//Console.WriteLine(vowelCount);
static int VowelsCount (string input)
{
    int VowelsCount = 0;
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
          || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') { VowelsCount++; }
    }
    return VowelsCount;
}

string input = Console.ReadLine();

int resutl = VowelsCount(input);
Console.WriteLine(resutl);