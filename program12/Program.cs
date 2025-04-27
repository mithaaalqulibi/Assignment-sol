namespace program12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine(" all numbers between 1 and 100 that are divisible by both 3 and 5:" +"   "+ i);
                }
            }
        }
    }
}
