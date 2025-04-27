using System.ComponentModel.Design;

namespace program13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("entar number to prints the multiplication table of it ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                
                {
                    Console.Write($" {number}X{i} =  {number * i} \n\n" + " ");




                }

                Console.Write("");


            }
        }
    }
}