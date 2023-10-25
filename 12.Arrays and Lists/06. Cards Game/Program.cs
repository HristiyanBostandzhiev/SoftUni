List<int> handOne = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> handTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


while(true)
{
    if (handOne.Count == 0 || handTwo.Count == 0)
    {
        if (handTwo.Count == 0) { Console.WriteLine($"First player wins! Sum: {handOne.Sum()}"); }
        else { Console.WriteLine($"Second player wins! Sum: {handTwo.Sum()}"); }
        break;
    }
    int handOneCurrentValue = handOne[0]; 
    int handTwoCurrentValue = handTwo[0]; 

    if (handOneCurrentValue > handTwoCurrentValue)
    {
        handOne.Add(handOneCurrentValue);
        handOne.Add(handTwoCurrentValue);
        handOne.Remove(handOneCurrentValue);
        handTwo.Remove(handTwoCurrentValue);
    }
    else if (handOneCurrentValue < handTwoCurrentValue)
    {
        handTwo.Add(handTwoCurrentValue);
        handTwo.Add(handOneCurrentValue);
        handTwo.Remove(handTwoCurrentValue);
        handOne.Remove(handOneCurrentValue);
    }
    else if (handOneCurrentValue == handTwoCurrentValue)
    {
        handOne.Remove(handOne[0]);
        handTwo.Remove(handTwo[0]);
    }
}