 namespace program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the star triangle: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // Print stars in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();



              
            }
        }
    }
}
