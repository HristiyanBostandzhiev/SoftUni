var first = int.Parse(Console.ReadLine());
var second = int.Parse(Console.ReadLine());
var third = int.Parse(Console.ReadLine());

var totalTimeInSecond = first + second + third;
var minutes = totalTimeInSecond / 60;
var seconds = totalTimeInSecond % 60;

if (seconds < 10)
    Console.WriteLine($"{minutes}:0{seconds}");
else
    Console.WriteLine($"{minutes}:{seconds}");