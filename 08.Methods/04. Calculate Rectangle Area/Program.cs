﻿namespace _04._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void rectangleArea(int width, int length)
        {
            int result = width * length;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            rectangleArea(width, length);
        }
    }
}
