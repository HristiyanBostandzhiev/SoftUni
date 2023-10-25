List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    bool foundAdjacent = false;
    List<int> updatedNums = new List<int>();

    for (int i = 0; i < nums.Count; i++)
    {
        if (i < nums.Count - 1 && nums[i] == nums[i + 1])
        {
            updatedNums.Add(nums[i] + nums[i + 1]);
            i++;
            foundAdjacent = true;
        }
        else
        {
            updatedNums.Add(nums[i]);
        }
    }

    if (!foundAdjacent)
    {
        break;
    }

    nums = updatedNums;
}

Console.WriteLine(string.Join(" ", nums));