int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int i in arr)
{
    foreach (int j in arr2)
    {
        if (i == j)
        {
            Console.Write(j + " ");
        }
    }
}