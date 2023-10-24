using System;

namespace ConsoleApp1
{
    internal abstract class Shape
    {
        public static int Count { get; set; } = 0;

        public static void ShowCount()
        {
            Console.WriteLine($"Shapes count: {Count}");
        }
        public abstract void Draw();

        public Shape()
        {
            Count++;
        }
    }
}
