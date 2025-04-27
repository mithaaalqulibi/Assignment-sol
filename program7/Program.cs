using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("entar number to find the factorial of it");
            int Num = int.Parse(Console.ReadLine());
            if (Num <= 0)
            {

                Console.WriteLine(" we can not find factorial for ngativ num");
            }


            else
            {
                long Factorial = 1;

                for (int i = 1; i <= Num; i++)
                {
                    Factorial *= i;
                }
                Console.WriteLine("Factorial is:" + Factorial);


            }
        }

    }
}
