namespace program17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" How  many numburs do you want to sum");
            int digitsnumber=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= digitsnumber; i++)
            {
                Console.Write(" entar the number");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
              Console.WriteLine(" the sum of the number is :" + sum);
        }
    }
}
