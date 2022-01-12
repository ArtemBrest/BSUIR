using System;

namespace OAIP_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int sum = 0, temp = i;
                do
                {
                    //Console.WriteLine("Число уходящие в сумму: " + temp % 10);
                    sum += temp % 10;
                    //Console.WriteLine("Результат деления условие: " + temp / 10);
                    temp /= 10;
                   
                }
                while (temp > 0);
                //Console.WriteLine("Пошел проверять совпалает ли квадрат");
                if (m == sum * sum)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
