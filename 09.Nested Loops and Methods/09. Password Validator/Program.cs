static bool CheckLenght(string input)
{
    if (input.Length >= 6 && input.Length <= 10)
    {
        return true;
    }
    return false;
}
static bool CheckContent(string input)
{
    for (int pos = 0; pos < input.Length; pos++)
    {
        char symbol = input[pos];
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }
    return true;
}
static bool CheckFoTwoDigitisAtLeast(string input)
{
    int digits = 0;

    for (int pos = 0; pos < input.Length; pos++)
    {
        char symbol = input[pos];
        if (char.IsDigit(symbol) == true)
        {
            digits += 1;
        }
        if (digits >= 2)
        {
            return true;
        }
    }
    return false;
}

string password = Console.ReadLine();

bool lenght = CheckLenght(password);
bool content = CheckContent(password);
bool digits = CheckFoTwoDigitisAtLeast(password);

if (lenght == true && content == true && digits == true)
{
    Console.WriteLine("Password is valid");
}

else
{
    if (lenght == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (content == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if (digits == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}