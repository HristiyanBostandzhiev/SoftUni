static int GreaterOfTwoIntegers (int num1, int num2)
{
    if (num1 > num2) { return num1; }
    else { return num2; }
}
static char GreaterOfTwoChars (char char1, char char2)
{
    if (char1 > char2) { return char1; }
    else { return char2; }
}
static string GreaterOfTwoStrings (string string1, string string2)
{
    if (string1.CompareTo(string2) > 0) { return string1; }
    else { return string2; }
}

string type = Console.ReadLine ();
string input  = Console.ReadLine ();
string input2  = Console.ReadLine ();

if (type == "int")
{
    int num = int.Parse (input);
    int num2 = int.Parse (input2);
    int result = GreaterOfTwoIntegers(num, num2);
    Console.WriteLine(result);
}
else if (type == "char")
{
    char char1 = char.Parse(input);
    char char2 = char.Parse(input2);
    char result = GreaterOfTwoChars(char1, char2);
    Console.WriteLine(result);
}
else if (type == "string")
{
    string result = GreaterOfTwoStrings(input, input2);
    Console.WriteLine(result);
}