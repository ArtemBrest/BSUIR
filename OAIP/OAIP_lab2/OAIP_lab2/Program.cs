using System;

namespace OAIP_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			double x1 = 0, y1 = 0, r1 = 0, x2 = 0, y2 = 0, r2 = 0;
			try
			{
				Console.Write("x1 = ");
				x1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("y1 = ");
				y1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("r1 = ");
				r1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("x2 = ");
				x2 = Convert.ToDouble(Console.ReadLine());
				Console.Write("y2 = ");
				y2 = Convert.ToDouble(Console.ReadLine());
				Console.Write("r2 = ");
				r2 = Convert.ToDouble(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine("Входная строка не имела числового формата.");
			}
			if (x1 == x2 && y1 == y2 && r1 == r2)
			{
				Console.WriteLine("Окружности совпадают");
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) == r1 + r2 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r2 == r1 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r1 == r2)
			{
				Console.WriteLine("Пересекаются в 1 точке"); // (1,1,4) (9,1,4)
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) > r1 + r2)
			{
				Console.WriteLine("Не пересекаются!");
			}
			else if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r2 < r1 || Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + r1 < r2)
			{
				Console.WriteLine("Не пересекаются!");
			}
			else
			{
				Console.Write("Пересекаются в 2-ух точках");
			}
		}
    }
}
