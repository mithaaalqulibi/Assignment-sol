using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter num:");
            int num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine($"{num} is not prime");
                return;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($" {num}is not prime");
                    return ;
                }
                else { Console.WriteLine($"{num}is prime "); }
            }

           
         
                


            
        }
    }
}