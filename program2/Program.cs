namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int sum = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                sum += i;

            }
                Console.WriteLine("The sum of even numbers from 1 to 100 is" +"  " +sum);

            
        }
    }
}
