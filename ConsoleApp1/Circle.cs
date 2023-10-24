using System;

namespace ConsoleApp1
{
    internal class Circle: Shape
    {
        public int Diameter { get; set; }

        //public virtual void Draw()
        public override void Draw()
        {
            Console.WriteLine("==============Circle==============");
            Console.WriteLine($"Diameter: {Diameter}");
            Console.WriteLine("=====================================");
        }
        public Circle(): base()
        {
            Diameter = 0;
        }

        public Circle(int diameter): base()
        {
            Diameter = diameter;
        }
    }
}
