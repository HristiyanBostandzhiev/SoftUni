static void MagicNumbers (int integer)
{
    int initialInteger = integer;
    while (integer < 999)
    {
        while (true)
        {
            int digitOne = integer % 10;
            int digitTwo = (integer / 10) % 10;
            int digitThree = integer / 100;
            int result = digitOne * digitTwo * digitThree;
            if (result == initialInteger)
            {
                Console.Write($"{digitThree}{digitTwo}{digitOne} ");
            }
            if (integer / 10000 == 0)
            {
                break;
            }
        }
        integer++;
    }
}

int integer = int.Parse(Console.ReadLine());
MagicNumbers(integer);