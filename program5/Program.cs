namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int a = 0;
            int b = 1;
           
            Console.WriteLine("first 15 fibonacci  number is:");
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(a + " ");
                int sum = a + b;
                a = b;
                b = sum;



            }
        }
    }
}
