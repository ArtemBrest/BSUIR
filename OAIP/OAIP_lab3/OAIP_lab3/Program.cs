using System;

namespace OAIP_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 2;          
            int a, result = 0;
            Console.WriteLine("Введите число в 2 системе счисления: ");
            string A = Console.ReadLine();
            try
            {
                a = Convert.ToInt32(A);
                for (int i = A.Length - 1, mul = 0; i >= 0; i--, mul++)
                {
                    //result += (int)Math.Pow(N, mul) * (Char.IsDigit(A[i]) ? (int)Char.GetNumericValue(A[i]) : (A[i] - 55));                   
                    if (Char.IsDigit(A[i]))
                    {
                        result += (int)Math.Pow(N, mul) * (int)Char.GetNumericValue(A[i]);
                    }
                    else
                    {
                        result += (int)Math.Pow(N, mul) * (A[i] - 55);
                    }
                }
                Console.WriteLine("Число в 10 системе счисления: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Введено не int");
            }
            Console.ReadKey();
        }
    }
}
