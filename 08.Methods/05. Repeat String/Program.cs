namespace _05._Repeat_String
{
    internal class Program
    {
        static void repeatString (string text, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write(text);
            }
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            repeatString(text, count);
        }
    }
}
