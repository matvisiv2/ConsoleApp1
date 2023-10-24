using System;

namespace ConsoleApp1
{
    class Square: Rectangle
    {
        public override void Draw()
        {
            Console.WriteLine("==============Square==============");
            Console.WriteLine($"Side: {Width}");
        }

        public Square(): base(0, 0) { }

        public Square(int side): base(side, side) { }
    }
}