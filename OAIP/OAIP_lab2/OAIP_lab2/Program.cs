using System;

namespace OAIP_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Console.Write("x1 = ");
			double x1 = double.Parse(Console.ReadLine());
			Console.Write("y1 = ");
			double y1 = double.Parse(Console.ReadLine());
			Console.Write("r1 = ");
			double r1 = double.Parse(Console.ReadLine());
			Console.Write("x2 = ");
			double x2 = double.Parse(Console.ReadLine());
			Console.Write("y2 = ");
			double y2 = double.Parse(Console.ReadLine());
			Console.Write("r2 = ");
			double r2 = double.Parse(Console.ReadLine());

			if (x1 == x2 && y1 == y2 && r1 == r2)
			{
				Console.Write("Окружности совпадают");
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) == r1 + r2 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r2 == r1 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r1 == r2)
			{
				Console.Write("Пересекаются в 1 точке"); // (1,1,4) (9,1,4)
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) > r1 + r2)
			{
				Console.Write("Не пересекаются!");
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r2 < r1 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r1 < r2)
			{
				Console.Write("Не пересекаются!");
			}
			else
			{
				Console.Write("Пересекаются в 2-ух точках");
			}
		}
    }
}
