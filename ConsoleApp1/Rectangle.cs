using System;

namespace ConsoleApp1
{
	class Rectangle : Shape, IPointy
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public int PointCount { get; set; }

		public void ShowPointCount()
		{
            Console.WriteLine($"Point count: {PointCount}");
        }
		public override void Draw()
		{
			Console.WriteLine("==============Rectangle==============");
			Console.WriteLine($"Width: {Width}");
			Console.WriteLine($"Height: {Height}");
			Console.WriteLine("=====================================");
		}

		public Rectangle(): base()
		{
			Width = 0;
			Height = 0;
			PointCount = 4;
		}

		public Rectangle(int width, int height): base()
		{
			Width = width;
			Height = height;
			PointCount = 4;
		}

	}
}